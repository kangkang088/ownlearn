using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.IO;
using Modbus.Device;
using System.IO.Ports;
using Microsoft.Win32;
using System.Windows.Forms.VisualStyles;
using Modbus;
using Modbus.Message;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        private string[] connectType = { "SerialPort" };
        private int[] serialBaud = { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200, 128000, 230400, 256000 };
        private int[] serialDataBit = { 5, 6, 7, 8 };
        private double[] serialStopBitCbb = { 1, 1.5, 2 };
        private StopBits[] serialStopBit = { StopBits.One, StopBits.OnePointFive, StopBits.Two };
        private string[] serialParityCbb = { "None Parity", "Odd Parity", "Even Parity" };
        private Parity[] serialParity = { Parity.None, Parity.Odd, Parity.Even };
        private string[] op_string = { "读线圈（01H）", "读离散输入（02H）", "读保存寄存器（03H）", "读输入寄存器（04H）", "写单个线圈（05H）", "写单个保存寄存器（06h）", "写多个线圈（0FH）", "写多个保存寄存器（10H）" };
        private byte[] op_code = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x0f, 0x10 };


        private SerialPort m_serialPort = null;
        private ModbusSerialMaster m_serialMaster = null;
        private ModbusSerialMaster rtu_serialMaster = null;
        private ModbusSerialMaster ascii_serialMaster = null;

        private bool isTransPortConnect = false;
        public Form1() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            DataBind();
        }
        //数据加载
        private void DataBind() {
            m_serialPort = new SerialPort();
            //UI连接类型
            comboBox1.DataSource = connectType;

            //UI串口号加载
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            if (registryKey != null) {
                string[] subKeys = registryKey.GetValueNames();
                comboBox2.Items.Clear();
                foreach (string item in subKeys) {
                    string sValue = (string)registryKey.GetValue(item);
                    comboBox2.Items.Add(sValue);
                }
                comboBox2.SelectedIndex = 0;
            }

            //波特率
            foreach (int item in serialBaud) {
                comboBox3.Items.Add(item + " Baud");
            }
            comboBox3.SelectedIndex = 11;

            //数据位
            foreach (int item in serialDataBit) {
                comboBox4.Items.Add(item + " DataBit");
            }
            comboBox4.SelectedIndex = 3;

            //校验位
            foreach (string item in serialParityCbb) {
                comboBox5.Items.Add(item);
            }
            comboBox5.SelectedIndex = 0;

            //停止位
            foreach (double item in serialStopBitCbb) {
                comboBox6.Items.Add(item + " StopBit");
            }
            comboBox6.SelectedIndex = 0;

            //功能码
            foreach (var item in op_string) {
                comboBox7.Items.Add(item);
            }
            comboBox7.SelectedIndex = 0;
            state_tssl.Text = $"软件初始化成功！";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (m_serialPort.IsOpen) {
                m_serialPort.Close();
                isTransPortConnect = false;
                state_tssl.Text = $"串口{m_serialPort.PortName}已经断开";
            }
        }
        //连接按钮
        private void button1_Click(object sender, EventArgs e) {
            //判断连接类型（当有多种连接类型时）
            //串口连接
            if (comboBox1.Text == connectType[0]) {
                if (!m_serialPort.IsOpen) {
                    try {
                        m_serialPort.PortName = comboBox2.Text;
                        m_serialPort.BaudRate = serialBaud[comboBox3.SelectedIndex];
                        m_serialPort.DataBits = serialDataBit[comboBox4.SelectedIndex];
                        m_serialPort.Parity = serialParity[comboBox5.SelectedIndex];
                        m_serialPort.StopBits = serialStopBit[comboBox6.SelectedIndex];

                        m_serialPort.Open();

                        rtu_serialMaster = ModbusSerialMaster.CreateRtu(m_serialPort);
                        ascii_serialMaster = ModbusSerialMaster.CreateAscii(m_serialPort);

                        rtu_serialMaster.Transport.ModbusTransPortWriteCompleted += new EventHandler<ModbusTransPortEventArgs>(writeComplete);
                        ascii_serialMaster.Transport.ModbusTransPortWriteCompleted += new EventHandler<ModbusTransPortEventArgs>(writeComplete);

                        if (radioButton1.Checked) {
                            m_serialMaster = rtu_serialMaster;
                        }
                        if (radioButton2.Checked) {
                            m_serialMaster = ascii_serialMaster;
                        }
                        

                        m_serialMaster.Transport.Retries = 2;
                        m_serialMaster.Transport.WriteTimeout = 2000;
                        m_serialMaster.Transport.ReadTimeout = 2000;

                        button1.Text = "断开";
                        isTransPortConnect = true;
                        state_tssl.Text = $"串口{m_serialPort.PortName}已经连接";
                    }
                    catch (Exception) {

                        throw;
                    }
                }
                else {
                    try {
                        if (m_serialPort.IsOpen) {
                            m_serialPort.Close();
                            isTransPortConnect = false;
                        }
                        button1.Text = "连接";
                        state_tssl.Text = $"串口{m_serialPort.PortName}已经断开";
                    }
                    catch (Exception) {

                        throw;
                    }
                }

            }
        }
        //发送指令完成事件-回调
        private void writeComplete(object sender, ModbusTransPortEventArgs e) {
            //显示发送的指令数据帧
            if (radioButton1.Checked) {
                textBox5.Text = Transform.ToHexString(e.Message);
            }
            else if (radioButton2.Checked) {
                textBox5.Text = Encoding.Default.GetString(e.Message);
            }
        }

        //读取按钮
        private void button3_Click(object sender, EventArgs e) {
            if (!isTransPortConnect) {
                MessageBox.Show("请检查连接状态！");
                return;
            }

            byte station = Convert.ToByte(textBox1.Text);
            ushort address = Convert.ToUInt16(textBox2.Text);
            ushort num = Convert.ToUInt16(textBox3.Text);

            Task.Run(new Action(() => {
                try {
                    switch (op_code[comboBox7.SelectedIndex]) {
                        case Modbus.Modbus.ReadCoils:
                            //读取线圈
                            bool[] result01 = m_serialMaster.ReadCoils(station, address, num);
                            textBox6.Text = (string.Join(",", result01));
                            break;
                        case Modbus.Modbus.ReadInputs:
                            //读取离散输入
                            bool[] result02 = m_serialMaster.ReadInputs(station, address, num);
                            textBox6.Text = (string.Join(",", result02));
                            break;
                        case Modbus.Modbus.ReadHoldingRegisters:
                            //读取保存寄存器
                            ushort[] result03 = m_serialMaster.ReadHoldingRegisters(station, address, num);
                            textBox6.Text = (string.Join(",", result03));
                            break;
                        case Modbus.Modbus.ReadInputRegisters:
                            //读取输入寄存器
                            ushort[] result04 = m_serialMaster.ReadInputRegisters(station, address, num);
                            textBox6.Text = (string.Join(",", result04));
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
                }
            }));
        }
        private string Show_ReceivedCmd(IModbusMessage result) {
            if (radioButton1.Checked) {
                return Transform.ToHexString(m_serialMaster.Transport.BuildMessageFrame(result));
            }
            else {
                return Encoding.ASCII.GetString(m_serialMaster.Transport.BuildMessageFrame(result));
            }
        }
        //写入按钮
        private void button4_Click(object sender, EventArgs e) {
            if (!isTransPortConnect) {
                MessageBox.Show("请检查连接状态！");
                return;
            }

            byte station = Convert.ToByte(textBox1.Text);
            ushort address = Convert.ToUInt16(textBox2.Text);
            ushort num = Convert.ToUInt16(textBox3.Text);

            Task.Run(new Action(() => {
                try {
                    switch (op_code[comboBox7.SelectedIndex]) {
                        case Modbus.Modbus.WriteSingleCoil: {
                                //m_serialMaster.WriteSingleCoil(station, address, Convert.ToBoolean("True"));

                                WriteSingleCoilRequestResponse res = m_serialMaster.WriteSingleCoilWithResponse(station, address, Convert.ToBoolean(textBox4.Text));//true false 
                                //textBox6.Text = Transform.ToHexString(m_serialMaster.Transport.BuildMessageFrame(res));
                                textBox6.Text = Show_ReceivedCmd(res);
                            }
                            break;
                        case Modbus.Modbus.WriteSingleRegister: {
                                //m_serialMaster.WriteSingleRegister(station, address, 123);
                                WriteSingleRegisterRequestResponse res = m_serialMaster.WriteSingleRegisterWithResponse(station, address, Convert.ToUInt16(textBox4.Text));//0-65535
                                //textBox6.Text = Transform.ToHexString(m_serialMaster.Transport.BuildMessageFrame(res));
                                textBox6.Text = Show_ReceivedCmd(res);
                            }
                            break;
                        case Modbus.Modbus.WriteMultipleCoils: {
                                //m_serialMaster.WriteMultipleCoils(station, address, new bool[] { true, false, false, true });
                                WriteMultipleCoilsResponse res = m_serialMaster.WriteMultipleCoilsWithResponse(station, address, Transform.ToBools(textBox4.Text, '|'));//true|false|false|true
                                //textBox6.Text = Transform.ToHexString(m_serialMaster.Transport.BuildMessageFrame(res));
                                textBox6.Text = Show_ReceivedCmd(res);
                            }
                            break;
                        case Modbus.Modbus.WriteMultipleRegisters: {
                                //m_serialMaster.WriteMultipleRegisters(station, address, new ushort[] { 123, 456, 789 });
                                WriteMultipleRegistersResponse res = m_serialMaster.WriteMultipleRegistersWithResponse(station, address, Transform.ToUInt16s(textBox4.Text, '|'));//123|456|789
                                //textBox6.Text = Transform.ToHexString(m_serialMaster.Transport.BuildMessageFrame(res));
                                textBox6.Text = Show_ReceivedCmd(res);
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex) {

                    MessageBox.Show(ex.ToString());
                }
            }));
        }
        //通过操作列表的选项控制写入
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox7.SelectedIndex <= 3) {
                textBox4.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = false;
            }
            else {
                textBox4.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = true;
            }
            if (comboBox7.SelectedIndex == 4 || comboBox7.SelectedIndex == 5) {
                textBox3.Enabled = false;
            }
            else {
                textBox3.Enabled = true;
            }
        }
        //RTU按钮
        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (m_serialPort.IsOpen) {
                if (radioButton1.Checked) {
                    m_serialMaster = rtu_serialMaster;
                }
                else {
                    m_serialMaster = ascii_serialMaster;
                }
            }
        }
        //ASCII按钮
        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (m_serialPort.IsOpen) {
                if (radioButton2.Checked) {
                    m_serialMaster = ascii_serialMaster;
                }
                else {
                    m_serialMaster = rtu_serialMaster;
                }
            }
        }
    }
}
