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

namespace WindowsFormsApp1 {
    public partial class Server : Form {
        public Server() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                //1.开始监听
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //创建ip地址和端口号对象
                IPAddress iP = IPAddress.Any;// = IPAddress.Parse(this.textBox1.Text)只能绑定一个(具体化)，any是绑定的本地可用的所有的ip（动态改变）
                IPEndPoint iPEndPoint = new IPEndPoint(iP, Convert.ToInt32(this.textBox2.Text));

                //负责监听的socket绑定ip地址和端口号
                socket.Bind(iPEndPoint);
                ShowMessage("监听成功");

                //设置监听队列-某一个时间点内能够连入服务端的最大客户端数量
                socket.Listen(10);

                //创建线程监听，避免假死
                Thread thread = new Thread(Listen_s);
                thread.IsBackground = true;
                thread.Start(socket);
            }
            catch {
            }



        }
        //2.循环监听并创建socket对象
        Socket socketSend;
        Dictionary<string, Socket> dictionary = new Dictionary<string, Socket>();
        private void Listen_s(object socket) {
            Socket sockets = socket as Socket;
            while (true) {
                try {
                    //2.负责监听的socket接受客户端连接,创建负责跟客户端通信的socketSend
                    socketSend = sockets.Accept();//应该把它存起来，不能用完一次就扔
                    //存入集合
                    dictionary.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    //存入下拉框
                    this.comboBox1.Items.Add(socketSend.RemoteEndPoint.ToString());
                    //获取监听到的远程客户端的ip地址和端口号
                    ShowMessage(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");

                    //3.客户端连接成功后，服务器接收客户端发来的消息(字节数组)(不停的接收)
                    Thread thread = new Thread(GetMessage);
                    thread.IsBackground = true;
                    thread.Start(socketSend);
                }
                catch { }
            }
        }
        //3.客户端连接成功后，服务器接收客户端发来的消息(字节数组)
        void GetMessage(object o) {
            Socket socketSend = o as Socket;
            while (true) {
                try {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);//实际接收的字节数
                    if (r == 0) { break; }
                    string str = Encoding.UTF8.GetString(buffer);//转换为字符串打印
                    ShowMessage(socketSend.RemoteEndPoint.ToString() + ":" + str);
                }
                catch {
                }
            }
        }
        void ShowMessage(string str) {
            this.textBox3.AppendText(str + "\r\n");
        }

        private void Server_Load(object sender, EventArgs e) {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        //4.发送消息给客户端
        private void button4_Click(object sender, EventArgs e) {
            //4.发送消息给客户端
            string str = this.textBox4.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            //添加标识
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(bytes);
            byte[] newBytes = list.ToArray();
            //获得用户在下拉框中选中的地址
            string ip = this.comboBox1.SelectedItem.ToString();
            dictionary[ip].Send(newBytes);
        }
        //选中要发送的文件
        private void button2_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            openFileDialog.Title = "请选择要发送的文件";
            openFileDialog.Filter = "所有文件|*.*";
            openFileDialog.ShowDialog();
            this.textBox5.Text = openFileDialog.FileName;

        }
        //发送文件
        private void button3_Click(object sender, EventArgs e) {
            string path = this.textBox5.Text;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read)) {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBytes = list.ToArray();
                dictionary[this.comboBox1.SelectedItem.ToString()].Send(newBytes, 0, r + 1, SocketFlags.None);
                MessageBox.Show("发送成功");
            }
        }
        //发送震动
        private void button5_Click(object sender, EventArgs e) {
            byte[] bytes = new byte[1];
            bytes[0] = 2;
            dictionary[this.comboBox1.SelectedItem.ToString()].Send(bytes);
        }
    }
}