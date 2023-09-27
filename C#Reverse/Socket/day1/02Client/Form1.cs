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

namespace _02Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket socketSend;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //1.创建负责通信的Socket 
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //跟谁通信？要知道远程服务器的ip和端口号
                IPAddress iPAddress = IPAddress.Parse(this.textBox1.Text);
                IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, Convert.ToInt32(this.textBox2.Text));
                //2.连接
                socketSend.Connect(iPEndPoint);
                ShowMessage("连接成功");

                //3.开启新线程不停的接收服务器发来的消息
                Thread thread = new Thread(Recive);
                thread.IsBackground = true;
                thread.Start();
            }
            catch { }
        }
        /// <summary>
        /// 客户端不停的接收服务器发来的消息
        /// </summary>
        void Recive()
        {
            while (true)
            {
                try
                {
                    //客户端接收服务器发来的消息
                    byte[] bytes = new byte[1024 * 1024 * 2];
                    //实际接收的有效字节数，包括首位标记
                    int r = socketSend.Receive(bytes);
                    if (r == 0) { break; }

                    //拿到首位标记判断怎么处理
                    int n = bytes[0];
                    //发送的文字消息
                    if (n == 0)
                    {
                        //加了标记，标记不要解析，所有要更新解析的数据
                        string str = Encoding.UTF8.GetString(bytes, 1, r - 1);
                        ShowMessage(socketSend.RemoteEndPoint + " : " + str);
                    }
                    else if (n == 1)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
                        saveFileDialog.Title = "请选择要保存的文件";
                        saveFileDialog.Filter = "所有文件|*.txt";
                        saveFileDialog.ShowDialog(this);
                        string path = saveFileDialog.FileName;
                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(bytes, 1, r - 1);

                        }
                        MessageBox.Show("保存成功");

                    }
                    else if (n == 2) 
                    {
                        ZhenDong();
                    }
                }
                catch { }
            }
        }
        /// <summary>
        /// 震动
        /// </summary>
        void ZhenDong()
        { 
            for (int i = 0; i < 500; i++) 
            {
                this.Location = new Point(200, 200);
                this.Location = new Point(280, 280);
            }
        }
        void ShowMessage(string str)
        {
            this.textBox3.AppendText(str + "\r\n");
        }
        /// <summary>
        /// 客户端给服务器发消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            string str = this.textBox4.Text.Trim();
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            socketSend.Send(bytes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
