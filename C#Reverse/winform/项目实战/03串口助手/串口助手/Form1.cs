using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串口助手 {
    public partial class Form1 : Form {
        public TransmitData transmitData;

        public event TransmitDataEventHandler transmitData2;

        private DecodedDataContext dataContext;
        public Form1() {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //begin when form has loaded
        //加载本地串口
        private void serialportLoad() {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");

            string[] strSubKeys = registryKey.GetValueNames();//所有串口的字符串名称

            foreach (string strSubKey in strSubKeys) {
                string portName = registryKey.GetValue(strSubKey).ToString();//获取串口的值（端口号）
                port_ComBox.Items.Add(portName);
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            //this.port_ComBox.Items.Add("COM4");
            //this.port_ComBox.Items.Add("COM5");
            serialportLoad();
            this.port_ComBox.SelectedIndex = 0;
            this.baud_ComBox.SelectedIndex = 1;
            this.checkBit_ComBox.SelectedIndex = 0;
            this.dataBit_ComBox.SelectedIndex = 3;
            this.stopBit_ComBox.SelectedIndex = 0;
            //EncodingInfo[] encodingInfos = Encoding.GetEncodings();

            Form2 form2 = new Form2();
            //transmitData = form2.ReveiveData;//窗体2接收窗体1的值-用委托
            transmitData2 += form2.receiveData2;//窗体2接收窗体1的值-用事件
            //form2.TransmitSend = sendBytes;//窗体1接收窗体2的值-委托
            form2.TransmitSend2 += sendbytes2;////窗体1接收窗体2的值-用事件
            form2.Show();

            dataContext = new DecodedDataContext(new SimpleDecodedDataFrame());
            //dataContext = new DecodedDataContext(new ModbusDecodedData());

        }
        //事件响应
        private void sendbytes2(object sender, TransmitEventArgs eventArgs) {
            serialPort1.Write(eventArgs.data, 0, eventArgs.data.Length);
            sendDataLength += eventArgs.data.Length;
        }

        //委托
        //private void sendBytes(byte[] data) {
        //    serialPort1.Write(data, 0, data.Length);
        //    sendDataLength += data.Length;
        //}


        //打开或关闭串口

        private bool isOpen = false;
        private void btnOpenPort_Click(object sender, EventArgs e) {
            try {
                if (serialPort1.IsOpen == false) {
                    serialPort1.PortName = port_ComBox.Text.Trim();
                    serialPort1.BaudRate = int.Parse(baud_ComBox.Text.Trim().ToString());
                    serialPort1.DataBits = int.Parse(dataBit_ComBox.Text.ToString().Trim());
                    switch (checkBit_ComBox.SelectedIndex) {
                        //none odd even
                        case 0: serialPort1.Parity = System.IO.Ports.Parity.None; break;
                        case 1: serialPort1.Parity = System.IO.Ports.Parity.Odd; break;
                        case 2: serialPort1.Parity = System.IO.Ports.Parity.Even; break;
                        default: serialPort1.Parity = System.IO.Ports.Parity.None; break;
                    }
                    switch (stopBit_ComBox.SelectedIndex) {
                        //1 1.5 2
                        case 0: serialPort1.StopBits = System.IO.Ports.StopBits.One; break;
                        case 1: serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive; break;
                        case 2: serialPort1.StopBits = System.IO.Ports.StopBits.Two; break;
                        default: serialPort1.StopBits = System.IO.Ports.StopBits.One; break;
                    }
                    serialPort1.Open();
                    isOpen = true;
                    btnOpenPort.Text = "关闭串口";

                }
                else {
                    serialPort1.Close();
                    isOpen = false;
                    btnOpenPort.Text = "打开串口";
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + serialPort1.PortName.ToString());
            }
        }


        //串口接收事件
        private List<byte> receiveBuffer = new List<byte>();//存储接收的数据(缓存区) 相比数组更加灵活

        private int receiveBufferLength = 0;//实际接收数

        private Queue<byte> bufferQueue = new Queue<byte>();//数据帧解析队列

        //private bool isHeadReceive = false;//帧头数据，默认为false（假设当前数据不是从想要的位置开始的），所以当为true时，队列必定是经过处理的

        //private int frameLength = 0;//帧长度
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {
            //接收数据的处理
            if (isReceive == false) return;

            byte[] dataTmp = new byte[serialPort1.BytesToRead];//获取缓冲区的可用字符长度并将字符数组设置为该大小

            serialPort1.Read(dataTmp, 0, dataTmp.Length);//从输入缓冲区中读取数据并存入字节数组

            receiveBuffer.AddRange(dataTmp);//将读取到的数据存入集合方便其他处理

            receiveBufferLength += dataTmp.Length;//实时更新接收的实际字节数

            transmitData?.Invoke(dataTmp);   //?.  如果transmitData不等于null，就执行
            transmitData2?.Invoke(this, new TransmitEventArgs { data = dataTmp });

            //异步-将辅助线程（上面处理数据用的）的数据更新到主线程UI界面（跨线程）
            this.Invoke(new EventHandler(delegate {
                //更新状态栏接收计数
                receiveNum_ToolStripStatus.Text = receiveBufferLength.ToString();

                if (startDataZhen.Checked == false) {

                    //如果我们接收的时候不选择以十六进制接收
                    if (hexReceiveCheckBox.Checked == false) {
                        string str = Encoding.GetEncoding("gb2312").GetString(dataTmp);

                        //我们现在接收，没选十六进制，万一那边发过来的数据是十六进制的，在里面要是有0x00，在这边获取成字符串，0x00就成了结束符\0，后面的数据就丢了，所有我们在添加到接收窗体之前先把里面的\0取消转义，变成普通字符。
                        str = str.Replace("\0", "\\0");
                        richTxtReceive.AppendText(str);

                        //richTxtReceive.AppendText(Encoding.GetEncoding("gb2312").GetString(dataTmp).Replace("\0", "\\0"));
                    }
                    else {
                        //以十六进制的格式接收数据并显示
                        richTxtReceive.AppendText(Transform.ToHexString(dataTmp, " "));
                    }
                }
                else { //数据帧解析  queue队列（先进先出） 帧 = 0x7f（帧头） + 长度 + 数据 + CRC（2个字节） 
                    foreach (byte item in dataTmp) {
                        //入列
                        bufferQueue.Enqueue(item);//把数据添加到队列中
                    }
                    byte[] frameData = dataContext.GetDataFrame(bufferQueue);
                    if (frameData != null) {
                        Console.WriteLine($"show the data in frameData{Transform.ToHexString(frameData)}");
                        txtDataZhen.Text = Transform.ToHexString(frameData);//拿到正确帧并显示（默认十六进制）
                        txtData1.Text = String.Format("{0:X2}", frameData[2]);
                        txtData2.Text = String.Format("{0:X2}", frameData[3]);
                        txtData3.Text = String.Format("{0:X2}", frameData[4]);
                        txtData4.Text = String.Format("{0:X2}", frameData[5]);
                        for (int i = 0; i < frameData.Length; i++) {
                            bufferQueue.Dequeue();
                        }
                    }


                    #region 高耦合度解析
                    //耦合度很高，解析数据帧的操作和解析数据帧的算法耦合度很高
                    //if (isHeadReceive == false) { //从帧头开始接收数据，如果当前开始的数据不是帧头的数据，全部去掉
                    //    foreach (byte item in bufferQueue) {
                    //        if (item != 0x7f) {
                    //            bufferQueue.Dequeue();//出列-循环去掉数据
                    //        }
                    //        else { 
                    //            isHeadReceive = true;//接收到帧头，把帧头标识设为true表示当前队列是从帧头开始的。停止循环
                    //            break;//队列（以帧头开始）处理完毕
                    //        }
                    //    }
                    //}
                    //if (isHeadReceive == true) { //到达帧头了
                    //    //判断是否有数据帧长度，如果队列长度就是一，说明只有一个帧头
                    //    if (bufferQueue.Count >= 2) {
                    //        frameLength = bufferQueue.ToArray()[1];//拿到帧包含的数据的长度
                    //        //获取数据（一帧完整的数据长度的判断，不代表数据是正确的，还需要校验）
                    //        if (bufferQueue.Count >= 1 + 1 + frameLength + 2) {
                    //            byte[] frameBuffer = new byte[1 + 1 + frameLength + 2];//将待校验的数据帧存入字节数据
                    //            Array.Copy(bufferQueue.ToArray(),0,frameBuffer,0,frameBuffer.Length);
                    //            //校验
                    //            if (crc_check(frameBuffer)) {
                    //                Console.WriteLine("frame is check correctly!");
                    //                txtDataZhen.Text = Transform.ToHexString(frameBuffer);//拿到正确帧并显示（默认十六进制）
                    //                txtData1.Text = String.Format("{0:X2}", frameBuffer[2]);
                    //                txtData2.Text = String.Format("{0:X2}", frameBuffer[3]);
                    //                txtData3.Text = String.Format("{0:X2}", frameBuffer[4]);
                    //                txtData4.Text = String.Format("{0:X2}", frameBuffer[5]);
                    //            }
                    //            else {
                    //                //无效数据
                    //                Console.WriteLine("bad frame,drop it!");
                    //            }
                    //            for (int i = 0; i < 1 + 1 + frameLength + 2; i++) { 
                    //                bufferQueue.Dequeue() ;//不论数据是否正确，都要出列
                    //            }
                    //            isHeadReceive = false;//重置帧头标识。重新处理队列
                    //        }
                    //    }
                    //}
                    #endregion
                }

            }));

            //string dataReceive = serialPort1.ReadExisting();
            //richTxtReceive.AppendText(dataReceive); 
        }
        //校验方法
        //private bool crc_check(byte[] frameBuffer) {
        //    //解析帧--考虑大小端问题
        //    /*大端模式：是指数据的高字节保存在内存的低地址中，而数据的低字节保存在内存的高地址中，这样的存储模式有点儿类似于把数据当作字符串顺序处理。地址由小向大增加，而数据从高位往低位放；这和我们的阅读习惯一致。
        //      小端模式：是指数据的高字节保存在内存的高地址中,而数据的低字节保存在内存的低地址中，这种存储模式将地址的高低和数据位权有效地结合起来，高
        //      地址部分权值高，低地址部分权值低。*/

        //    bool ret = false;//校验位检测标识
        //    byte[] temp = new byte[frameBuffer.Length - 2];//获取数据帧，去除CRC长度
        //    Array.Copy(frameBuffer, 0, temp, 0, temp.Length);
        //    byte[] crcData = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);//获取指定校验方法的校验位
        //    if (crcData[0] == frameBuffer[frameBuffer.Length - 2] && crcData[1] == frameBuffer[frameBuffer.Length - 1]) {
        //        ret = true;//校验位正确
        //    }
        //    return ret;
        //}


        //暂停接收或开始接收
        private bool isReceive = true;
        private void btnStop_Click(object sender, EventArgs e) {
            if (isReceive == true) {
                isReceive = false;
                btnStop.Text = "取消暂停";
            }
            else {
                isReceive = true;
                btnStop.Text = "暂停";
            }
        }
        //接收区切换十六进制与普通显示
        private void hexReceiveCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (richTxtReceive.Text == "") return;
            //十六进制显示
            if (hexReceiveCheckBox.Checked == true) {
                richTxtReceive.Text = Transform.ToHexString(receiveBuffer.ToArray(), " ");
            }
            else {
                richTxtReceive.Text = Encoding.GetEncoding("gb2312").GetString(receiveBuffer.ToArray()).Replace("\0", "\\0");
            }
        }
        //接收区清空
        private void btnClear_Click(object sender, EventArgs e) {
            receiveBuffer.Clear();
            receiveBufferLength = 0;
            receiveNum_ToolStripStatus.Text = "";
            richTxtReceive.Text = string.Empty;
        }
        //接收区自动清空
        private void autoClearCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (autoClearCheckBox.Checked == true) {
                timer1.Start();
            }
        }
        //计时器事件
        private void timer1_Tick(object sender, EventArgs e) {
            if (richTxtReceive.Text.Length >= 4096) {
                MessageBox.Show(sender.ToString());
                MessageBox.Show(e.ToString());
                receiveBuffer.Clear();
                receiveBufferLength = 0;
                receiveNum_ToolStripStatus.Text = "";
                richTxtReceive.Text = string.Empty;
            }
            else {
                timer1.Stop();
            }
        }


        //发送计数
        private int sendDataLength = 0;
        private void sendData() {
            serialPort1.Write(sendBuffer.ToArray(), 0, sendBuffer.Count);
            sendDataLength += sendBuffer.Count;
            //状态栏发送计数更新
            sendNum_ToolStripStatus.Text += sendDataLength.ToString();
        }
        //发送数据
        private void btnSend_Click(object sender, EventArgs e) {
            if (richTxtSend.Text != "" && serialPort1.IsOpen == true) {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                sendData();
            }
            else { MessageBox.Show("The data should not be null and port must be open!!"); }
        }
        //发送窗口不再是活动窗口时
        private List<byte> sendBuffer = new List<byte>();//存储发送的数据（缓存区）
        private void richTxtSend_Leave(object sender, EventArgs e) {
            //以十六进制格式发送
            if (hexSendCheckBox.Checked == true) {
                //检测是不是十六进制
                if (DataEncoding.IsHexString(richTxtSend.Text.Replace(" ", ""))) {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Transform.ToBytes(richTxtSend.Text.Replace(" ", "")));
                }
                else {
                    MessageBox.Show("请输入正确的十六进制");
                    richTxtSend.Select();
                }
            }
            else {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding("gb2312").GetBytes(richTxtSend.Text));
            }
        }

        private void richTxtSend_TextChanged(object sender, EventArgs e) {

        }
        //发送区内容是否以十六进制显示
        private void hexSendCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (richTxtSend.Text == "") { return; }
            if (hexSendCheckBox.Checked == true) {
                richTxtSend.Text = Transform.ToHexString(sendBuffer.ToArray(), " ");
            }
            else {
                richTxtSend.Text = Encoding.GetEncoding("gb2312").GetString(sendBuffer.ToArray()).Replace("\0", "\\0");
            }
        }
        //发送区清空
        private void btnClearSend_Click(object sender, EventArgs e) {
            sendBuffer.Clear();
            sendDataLength = 0;
            sendNum_ToolStripStatus.Text = string.Empty;
        }
        //自动发送
        private void autoSendCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (serialPort1.IsOpen == false && autoSendCheckBox.Checked == true) {
                autoSendCheckBox.Checked = false;
                if (timer2 != null) {
                    timer2.Enabled = false;
                    timer2.Stop();
                    timer2 = null;
                }
                MessageBox.Show("串口未打开，发送失败");
                return;
            }
            if (serialPort1.IsOpen == true && autoSendCheckBox.Checked == true) {
                txtTimeOfSend.Enabled = false;
                btnSend.Enabled = false;
                int i = Convert.ToInt32(txtTimeOfSend.Text);
                if (i < 10 || i < 60 * 1000) {
                    i = 1000;
                    txtTimeOfSend.Text = i.ToString();
                    MessageBox.Show("自动发送数据的周期范围在10-60000毫秒");
                }
                timer2.Interval = i;
                timer2.Start();
            }
            else {
                btnSend.Enabled = true;
                txtTimeOfSend.Enabled = true;
                if (timer2 != null) {
                    timer2.Stop();
                    timer2 = null;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e) {
            if (richTxtSend.Text != "" && serialPort1.IsOpen == true) {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                sendData();
            }
            else {
                statusStrip1.Text = "请先输入发送数据";
                Console.WriteLine("The data should not be null and port must be open!!");
            }
        }
        //清空计数
        private void clearNum_ToolStripStatus_Click(object sender, EventArgs e) {
            sendBuffer.Clear();
            sendDataLength = 0;
            sendNum_ToolStripStatus.Text = string.Empty;
            receiveBuffer.Clear();
            receiveBufferLength = 0;
            receiveNum_ToolStripStatus.Text = "";
        }

        private void RTSCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (RTSCheckBox.Checked == true) {
                serialPort1.RtsEnable = true;
            }
            else {
                serialPort1.RtsEnable = false;
            }
        }

        private void DTRCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (DTRCheckBox.Checked == true) {
                serialPort1.DtrEnable = true;
            }
            else {
                serialPort1.DtrEnable = false;
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                txtReecive.Text = dialog.SelectedPath;
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e) {
            if (txtReecive.Text == "") {
                return;
            }
            string fileName = txtReecive.Text + "\\" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";
            StreamWriter streamWriter = new StreamWriter(fileName);
            streamWriter.Write(txtReecive.Text);
            streamWriter.Flush();
            streamWriter.Close();
            MessageBox.Show("保存成功");
        }
        string read;
        private void btnOpenFile_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的文件";
            openFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                txtSend.Text = fileName;
                StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding("gb2312"));
                read = sr.ReadToEnd();
                richTxtSend.Text = read;
                sr.Close();
            }
        }

        private async void btnSendFile_Click(object sender, EventArgs e) {
            if (read == "") {
                MessageBox.Show("请先选择文件");
            }
            try {
                byte[] bytes = Encoding.GetEncoding("gb2312").GetBytes(read);
                sendDataLength += bytes.Length;
                sendNum_ToolStripStatus.Text = sendDataLength.ToString();
                int pagenum = bytes.Length / 4096;
                int remaind = bytes.Length % 4096;
                for (int i = 0; i < pagenum; i++) {
                    serialPort1.Write(bytes, (i*4096), 4096);
                    await Task.Delay(10);
                }
                if (remaind > 0) {
                    serialPort1.Write(bytes, pagenum * 4096, remaind);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("mistake message:" + ex.Message);
            }
        }
    }
}
