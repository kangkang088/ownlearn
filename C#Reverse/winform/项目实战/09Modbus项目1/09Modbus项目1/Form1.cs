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

namespace _09Modbus项目1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.portcmb.DataSource = SerialPort.GetPortNames();
            this.baudcmb.DataSource = new string[] { "2400", "4800", "9600" };
            this.stationAddresscmb.DataSource = new string[] { "1", "2", "3", "4", "5" };
        }
        private SerialPort serialPort;

        private void btnconnect_Click(object sender, EventArgs e) {
            if (this.btnconnect.Text == "建立连接") {
                try {
                    serialPort = new SerialPort();
                    //MessageBox.Show(serialPort.PortName.ToString() +"," + serialPort.BaudRate.ToString() +"," +  serialPort.Parity.ToString() + "," + serialPort.DataBits.ToString() + "," +  serialPort.StopBits.ToString());
                    serialPort.BaudRate = int.Parse(baudcmb.Text);
                    serialPort.PortName = this.portcmb.Text;

                    serialPort.Open();
                    this.btnconnect.Text = "断开连接";
                }
                catch (Exception ex) {

                    MessageBox.Show("连接失败:" + ex.Message);
                }
            }
            else {

                serialPort?.Close();
                this.btnconnect.Text = "建立连接";
            }
        }

        private void btnwrite_Click(object sender, EventArgs e) {
            if (serialPort.IsOpen) {
                //1.拼接报文
                List<byte> sendCommand = new List<byte>();
                //从站地址 1字节  1
                sendCommand.Add(Convert.ToByte(stationAddresscmb.Text));
                //功能码 1字节    2
                sendCommand.Add(0x03);
                //起始地址 2字节  3，4
                sendCommand.AddRange(new byte[] { 0x00, 0x00 });
                //数量 2字节     5，6
                sendCommand.AddRange(new byte[] { 0x00, 0x02 });
                //校验位 2字节   7，8  CRC16（位，返回两个字节）
                byte[] crc = CRCCheck.CalculateCRC16(sendCommand.ToArray(), 6);
                sendCommand.AddRange(crc);

                //2.发送报文
                serialPort.Write(sendCommand.ToArray(), 0, sendCommand.Count);

                Thread.Sleep(1000);

                //3.接收报文
                byte[] buffer = new byte[serialPort.BytesToRead];
                serialPort.Read(buffer, 0, buffer.Length);

                //4.验证
                if (CRCCheck.CRCVerify(buffer)) {
                    if (buffer[0] == sendCommand[0] && buffer[1] == sendCommand[1]) {

                        byte[] data = new byte[4];//一个数据用两个字节，两个数据四个字节

                        Array.Copy(buffer, 3, data, 0, 4);

                        //湿度
                        ushort humidity =Convert.ToUInt16(data[0] * 256 + data[1] * 256);
                        this.lblshidu.Text = (humidity * 0.1f).ToString();
                        //温度
                        ushort tempura =Convert.ToUInt16(data[2] * 256 + data[3] * 256);
                        this.lblwendu.Text = (tempura * 0.1f).ToString();
                    }
                }
            }
        }

    }
}
