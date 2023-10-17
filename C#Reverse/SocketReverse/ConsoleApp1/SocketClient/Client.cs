using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketClient {
    public partial class Client : Form {
        public Client() {
            InitializeComponent();
        }
        Socket socket;
        private void button1_Click(object sender, EventArgs e) {
            //1.创建负责通信的socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //2.连接服务器
            IPAddress iP = IPAddress.Parse(this.textBox1.Text);
            IPEndPoint iPEndPoint = new IPEndPoint(iP, Convert.ToInt32(this.textBox2.Text));
            socket.Connect(iPEndPoint);
            ShowMessage("连接成功");

            Thread thread = new Thread(GetMessage);
            thread.IsBackground = true;
            thread.Start();
        }
        void ShowMessage(string str) {
            this.textBox3.AppendText(str + "\r\n");
        }

        private void button4_Click(object sender, EventArgs e) {
            //3.发送消息
            string str = this.textBox4.Text + "\r\n";
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            socket.Send(bytes);
        }
        //4.接收服务端发来的消息
        void GetMessage() {
            while (true) {
                byte[] buffer = new byte[1024 * 1024 * 2];
                int r = socket.Receive(buffer);
                if (r == 0) { break; }
                //判断标识
                int n = buffer[0];
                if (n == 0) {
                    //文字
                    string str = Encoding.UTF8.GetString(buffer, 1, r - 1);
                    ShowMessage(socket.RemoteEndPoint.ToString() + ":" + str);
                }
                else if (n == 1) {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
                    saveFileDialog.Title = "请选择要保存的文件";
                    saveFileDialog.Filter = "所有文件|*.*";
                    saveFileDialog.ShowDialog(this);
                    string str = saveFileDialog.FileName;
                    using (FileStream fsWrite = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Write)) {
                        fsWrite.Write(buffer, 1, r - 1);
                    }
                    MessageBox.Show("保存成功");
                }
                else if (n == 2) {
                    ZD();
                }


            }
        }
        void ZD() {
            for (int i = 0; i < 500; i++) {
                this.Location = new Point(200,280);
                this.Location = new Point(280,280);

            }
        }
        private void Client_Load(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
