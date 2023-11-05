using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using _10监控预警系统.Models;
using _10监控预警系统.UControls;
using Modbus.Device;

namespace _10监控预警系统 {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }
        IModbusMaster master = null;//主站设备
        SerialPort serialPort = null;//串口对象
        List<SlaveInfo> slaves = new List<SlaveInfo>();//存储从站信息列表
        List<ParaInfo> paraInfos = new List<ParaInfo>();//存储参数列表
        List<AlarmInfo> alarmInfos = new List<AlarmInfo>();//存储预警信息列表
        System.Timers.Timer timer = null;//定时器。用来定时采集数据的
        bool isStart = false;//标识设备运行状态
        Task tCheck = null;//检测线程
        CancellationTokenSource source = new CancellationTokenSource();//取消线程执行
        ManualResetEvent resetEvent = new ManualResetEvent(true);
        bool isFirst = false;//第一次采集数据是否完成
        Dictionary<string,string> dicValue = new Dictionary<string,string>();//存储实时采集参数值
        private void FrmMain_Load(object sender, EventArgs e) {
            //加载从站列表
            LoadSalveList();
            //加载参数列表
            LoadParaList();
            //加载预警设置列表
            LoadAlarmSetList();
            //创建串口对象及主站设备
            CreateConn();
            //初始化定时器
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;//重复执行
            timer.Elapsed += Timer_Elapsed;
        }
        /// <summary>
        /// 加载预警设置列表
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void LoadAlarmSetList() {
            XmlDocument doc = new XmlDocument();
            string path = Application.StartupPath + "/ConfigFiles/XAlarmValueSet.xml";
            doc.Load(path);
            XmlElement root = doc.DocumentElement;//根节点
            if (root != null) {
                foreach (XmlNode node in root.ChildNodes) {
                    AlarmInfo alarmInfo = new AlarmInfo();
                    alarmInfo.ParaType = (node.SelectSingleNode("ParaType").InnerText);
                    alarmInfo.AlarmType = int.Parse(node.SelectSingleNode("AlarmType").InnerText);
                    alarmInfo.AlarmValue = (node.SelectSingleNode("AlarmValue").InnerText);
                    alarmInfos.Add(alarmInfo);
                }
            }
        }
        /// <summary>
        /// 加载参数列表
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void LoadParaList() {
            XmlDocument doc = new XmlDocument();
            string path = Application.StartupPath + "/ConfigFiles/XParas.xml";
            doc.Load(path);
            XmlElement root = doc.DocumentElement;//根节点
            if (root != null) {
                foreach (XmlNode node in root.ChildNodes) {
                    ParaInfo paraInfo = new ParaInfo();
                    paraInfo.ParaName = (node.SelectSingleNode("ParaName").InnerText);
                    paraInfo.SlaveId = byte.Parse(node.SelectSingleNode("SlaveId").InnerText);
                    paraInfo.Address = ushort.Parse(node.SelectSingleNode("Address").InnerText);
                    paraInfo.DataType = (node.SelectSingleNode("DataType").InnerText);
                    paraInfo.Note = (node.SelectSingleNode("Note").InnerText);
                    paraInfos.Add(paraInfo);
                }
            }
        }
        /// <summary>
        /// 加载从站列表
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void LoadSalveList() {
            XmlDocument doc = new XmlDocument();
            string path = Application.StartupPath + "/ConfigFiles/XSlave.xml";
            doc.Load(path);
            XmlElement root = doc.DocumentElement;//根节点
            if (root != null) {
                foreach (XmlNode node in root.ChildNodes) {
                    SlaveInfo slave = new SlaveInfo();
                    slave.SlaveId = byte.Parse(node.SelectSingleNode("SlaveId").InnerText);
                    slave.FunctionCode = byte.Parse(node.SelectSingleNode("FunctionCode").InnerText);
                    slave.StartAddress = ushort.Parse(node.SelectSingleNode("StartAddress").InnerText);
                    slave.Count = ushort.Parse(node.SelectSingleNode("Count").InnerText);
                    slaves.Add(slave);
                }
            }
        }
        /// <summary>
        /// 创建串口对象及主站设备
        /// </summary>
        private void CreateConn() {
            serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            if (serialPort != null) {
                try {
                    serialPort.Open();
                    if (serialPort.IsOpen) {
                        //创建主站设备
                        master = ModbusSerialMaster.CreateRtu(serialPort);
                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// 定时器实时采集与检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            //定时读与加载
            ReadAndLoad();
        }
        /// <summary>
        /// 定时读与加载
        /// </summary>
        private void ReadAndLoad() {
            Task.Run(async () => {
                //读
                foreach (var slave in slaves) {
                    if (slave.FunctionCode == 1) {
                        //线圈
                        bool[] bls = await master.ReadCoilsAsync(slave.SlaveId,slave.StartAddress, slave.Count);
                        if (bls.Length > 0) { 
                            //筛选从站相关的参数
                            List<ParaInfo> paras = paraInfos.Where(p=>p.SlaveId == slave.SlaveId).ToList();
                            //解析与存储
                            foreach (ParaInfo para in paras) {
                                ushort addr = para.Address;
                                bool blVal = bls[addr];//取到参数值
                                if (!dicValue.ContainsKey(para.ParaName)) {
                                    dicValue.Add(para.ParaName, blVal.ToString());
                                }
                                else {
                                    dicValue[para.ParaName] = blVal.ToString();
                                }
                            }
                        }
                    }
                    else if(slave.FunctionCode == 3){
                        //保存寄存器
                        ushort[] uDatas = await master.ReadHoldingRegistersAsync(slave.SlaveId, slave.StartAddress, slave.Count);
                        if (uDatas.Length > 0) {
                            //筛选从站相关的参数
                            List<ParaInfo> paras = paraInfos.Where(p => p.SlaveId == slave.SlaveId).ToList();
                            //解析与存储
                            foreach (ParaInfo para in paras) {
                                ushort addr = para.Address;
                                ushort uData = uDatas[addr];//取到参数值
                                if (!dicValue.ContainsKey(para.ParaName)) {
                                    dicValue.Add(para.ParaName, uData.ToString());
                                }
                                else {
                                    dicValue[para.ParaName] = uData.ToString();
                                }
                            }
                        }
                    }
                }
                //检测
                if (!isFirst) { 
                    isFirst = true;//第一次采集完成
                    //初始化检测
                    InitAlarmList();
                    //启动实时检测线程
                    CheckAlarm();
                }
                //加载
                if (this.IsHandleCreated) {
                    this.Invoke(new Action(() => {
                        foreach (Control c in this.Controls) {
                            if (c is UPump) {
                                UPump uPump = c as UPump;
                                string pName = uPump.PumpStateName;
                                uPump.ActualState = bool.Parse(dicValue[pName]);
                            }
                            else if(c is ParaTextBox) {
                                ParaTextBox txt = c as ParaTextBox;
                                string pName = txt.VarName;
                                txt.DataVal = dicValue[pName];
                            }
                        }
                        //报警灯呈现
                        ShowWarning(txtPump01Fre, lightPump01Fre);
                        ShowWarning(txtPump01Power, lightPump01Power);
                        ShowWarning(txtPump02Fre, lightPump02Fre);
                        ShowWarning(txtPump02Power, lightPump02Power);
                        ShowWarning(txtPump03Fre, lightPump03Fre);
                        ShowWarning(txtPump03Power, lightPump03Power);
                    }));
                }
            });
        }
        /// <summary>
        /// 实时检测
        /// </summary>
        private void CheckAlarm() {
            var tk = source.Token;
            if (tCheck == null) {
                tCheck = Task.Run(() => {
                    while (true) {
                        if (tk.IsCancellationRequested) {
                            return;
                        }
                        var alarmsValues = lastAlarmValues;
                        if (alarmsValues.Count > 0) {
                            var paras = paraInfos.Where(p => p.SlaveId == 2).ToList();
                            foreach (AlarmInfo alarm in alarmInfos) {
                                string alarmType = alarm.AlarmType == 1 ? "L" : "H";
                                int.TryParse(alarm.AlarmValue, out int alarmValue);//获取报警临界值
                                var paras1 = paras.Where(p => p.ParaName.Contains(alarm.ParaType)).ToList();//筛选出与该参数类别相同的参数
                                foreach (ParaInfo para in paras1) {
                                    int curValue = int.Parse(dicValue[para.ParaName]);//当前值
                                    int oldValue = 0;//上次的值
                                    string keyName = para.ParaName + alarmType;//lastAlarmValues的Key
                                    if (alarmsValues.ContainsKey(keyName)) {
                                        oldValue = alarmsValues[keyName];//取出上次的值
                                        if (alarm.AlarmType == 1) {
                                            string alarmNote = para.Note + "低值报警";
                                            //低值异常：当前低于临界值，之前比临界值大
                                            if (curValue < alarmValue && oldValue >= alarmValue) {
                                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "LAlarm", curValue, alarmNote);
                                            }
                                            else if (curValue >= alarmValue && oldValue < alarmValue) {
                                                //当前正常，取消低值报警记录
                                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "UnLAlarm", curValue, alarmNote);
                                            }
                                        }
                                        else if (alarm.AlarmType == 2) {
                                            string alarmNote = para.Note + "高值报警";

                                            if (curValue > alarmValue && oldValue <= alarmValue) {
                                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "HAlarm", curValue, alarmNote);
                                            }
                                            else if (curValue <= alarmValue && oldValue > alarmValue) {

                                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "UnHAlarm", curValue, alarmNote);
                                            }
                                        }
                                        lastAlarmValues[keyName] = curValue;//最新采集到的值更新到最新检测数据中

                                    }
                                }
                            }
                        }
                        Task.Delay(1000);//挂起1s
                    }
                }, tk);
            }
            else { 
                resetEvent.Set();//重启线程
            }
        }

        //存储最新的用于检测的参数数据
        Dictionary<string,int> lastAlarmValues = new Dictionary<string,int>();
        /// <summary>
        /// 初始化检测，第一次采集完成才会执行
        /// </summary>
        private void InitAlarmList() {
            var paras = paraInfos.Where(p=>p.SlaveId == 2).ToList();
            foreach (AlarmInfo alarm in alarmInfos) {
                //L低值报警 H高值报警
                string alarmType = alarm.AlarmType == 1 ? "L" : "H";
                int.TryParse(alarm.AlarmValue, out int alarmValue);//获取报警临界值
                var paras1 = paras.Where(p=>p.ParaName.Contains(alarm.ParaType)).ToList();//筛选出与该参数类别相同的参数
                int val = 0;//参数实时值
                foreach (ParaInfo para in paras1) {
                    if (!lastAlarmValues.ContainsKey(para.ParaName + alarmType) && dicValue[para.ParaName].Length > 0) {
                        string strVal = dicValue[para.ParaName];
                        int.TryParse(strVal, out val);
                        lastAlarmValues.Add(para.ParaName + alarmType, val);//添加最新检测实时值
                        if (alarm.AlarmType == 1) {
                            if (val < alarmValue) {
                                //低值异常
                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "LAlarm", val, para.Note + "低值报警");
                            }
                        }
                        else if (alarm.AlarmType == 2) { 
                            if(val > alarmValue) {
                                //高值异常
                                AddAlarmInfo(alarm.AlarmType, para.ParaName, "HAlarm", val, para.Note + "高值报警");
                            }
                        }
                    }
                }
            }
        }
        int fId = 0;//编号初始值
        private void AddAlarmInfo(int aType, string paraName, string aState, int val, string note) { 
            int id = ++fId;
            AlarmLoginInfo loginInfo = new AlarmLoginInfo(id, DateTime.Now, paraName,aType, aState, val, note);
            //添加到预警记录列表中
            CommonClass.logList.Add(loginInfo);
            //刷新到预警列表页
            CommonClass.UpdateDGVAlarmList();
        }
        /// <summary>
        /// 处理对应参数的报警灯状态
        /// </summary>
        /// <param name="pTxt"></param>
        /// <param name="uLight"></param>
        private void ShowWarning(ParaTextBox pTxt, UCAlarmControl uLight) {
            string paraName = pTxt.VarName;//参数名
            var alarmLogList = CommonClass.logList.Where(p=>p.ParaName == paraName).OrderBy(p=>p.Id).ToList();
            if (alarmLogList.Count > 0) {
                var lastInfo = alarmLogList[alarmLogList.Count - 1];
                if (lastInfo.AlarmType == 1) {
                    if (lastInfo.AlarmState == "LAlarm") {
                        uLight.IsOn = true;
                        uLight.AlarmLightColor[1] = Color.LightBlue;
                    }
                    else {
                        uLight.IsOn = false;
                    }
                }
                else if(lastInfo.AlarmType == 2) {
                    if (lastInfo.AlarmState == "HAlarm") {
                        uLight.IsOn = true;
                        uLight.AlarmLightColor[1] = Color.Lime;
                    }
                    else {
                        uLight.IsOn = false;
                    }
                }
            }
        }

        /// <summary>
        /// 启动与停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e) {
            if (!isStart) {
                Start(true);//启动
                timer.Start();
                isStart = true;
                btnStart.Text = "停止";
                label1.Text = "运行中";
            }
            else {
                Start(false);//停止
                timer.Stop();
                isStart = false;
                //source.Cancel();//线程取消
                resetEvent.WaitOne();
                uPump1.ActualState = false;
                uPump2.ActualState = false;
                uPump3.ActualState = false; 
                
                foreach (Control control in this.Controls) {
                    if(control is UCAlarmControl) {
                        UCAlarmControl uCAlarmControl = control as UCAlarmControl;
                        if (uCAlarmControl.IsOn) { 
                            uCAlarmControl.IsOn = false;
                        }
                    }
                }
                btnStart.Text = "启动";
                label1.Text = "未启动";
            }
        }
        /// <summary>
        /// 设备的启停
        /// </summary>
        /// <param name="bl"></param>
        private void Start(bool bl) {
            SlaveInfo slave01 = slaves.Find(e => e.SlaveId == 1);
            master.WriteMultipleCoils(slave01.SlaveId, slave01.StartAddress, new bool[] { bl, bl, bl, bl });
        }
    }
}
