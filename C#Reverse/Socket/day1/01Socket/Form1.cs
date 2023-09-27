using System;
using System.CodeDom;
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

namespace _01Socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //1.创建一个负责监听的Socket
                //                                       ip-4                     流式                 Tcp 
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //监听谁？
                //2.创建自己的ip地址和端口号对象
                IPAddress ip = IPAddress.Any;//只能固定监听，后来ip可能会发送改变 IPAddress ip1 = IPAddress.Parse(this.textBox1.Text);
                IPEndPoint iPEndPoint = new IPEndPoint(ip, Convert.ToInt32(this.textBox2.Text));
                //3.让负责监听的Socket绑定ip地址和端口号
                socketWatch.Bind(iPEndPoint);

                ShowMessage("监听成功");
                //4.设置监听队列
                socketWatch.Listen(10);
                //解决单线程等待时的假死情况
                Thread thread = new Thread(Listen);
                thread.IsBackground = true;
                thread.Start(socketWatch);
            }
            catch { }
        }
        Socket socketSend;
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        /// <summary>
        /// 等待客户端链接，并且创建与之通讯的Socket
        /// </summary>
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            //要循环等待，不然只能链接一次
            while (true)
            {
                try
                {
                    //5.等待客户端链接 ,并创建一个负责通信的Socket 
                    socketSend = socketWatch.Accept();//存在问题：每来一个新客户端，原来的客户端都会被覆盖
                    //解决
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    this.comboBox1.Items.Add(socketSend.RemoteEndPoint.ToString());
                    //拿到接收的远程客户端的ip地址
                    ShowMessage(socketSend.RemoteEndPoint.ToString() + " : 链接成功");
                    //开启线程不停的接收客户端发送过来的消息，避免假死
                    Thread thread = new Thread(Recive);
                    thread.IsBackground = true;
                    thread.Start(socketSend);
                }
                catch { }
            }
        }
        /// <summary>
        /// 服务的不停的接收客户端发来的消息
        /// </summary>
        /// <param name="o"></param>
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //6.链接成功后，服务器接收客户端发来的消息,存入缓冲区
                    byte[] bytes = new byte[1024 * 1024 * 2];
                    //实际接收到的有效字节数
                    int r = socketSend.Receive(bytes);
                    //如果下线了，即关闭客户端发送信息的窗口了，接收到的消息为空，则立即停止不停接收客户端消息循环行为
                    if (r == 0) { break; }
                    string str = Encoding.UTF8.GetString(bytes, 0, r);
                    ShowMessage(socketSend.RemoteEndPoint + ":" + str);
                }
                catch
                { }
            }
        }
        void ShowMessage(string str)
        {
            this.textBox3.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 服务器给客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            string str = this.textBox4.Text;
            byte[] bytes = Encoding.UTF8.GetBytes(str);

            //在首位添加一个用于区分原文件类型的标记，让对方根据首位标记判断以何种方式解析字节数组中的数据
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(bytes);
            //将泛型集合转为数组
            //bytes = list.ToArray(); 不行，可以理解为数组名是指针常量，指向不可以改变，这样相当于改变指向
            byte[] newBytes = list.ToArray();
            try
            {
                //获得用户在下拉框中选择的地址
                string ip = this.comboBox1.SelectedItem.ToString();
                //找到对应的值
                dicSocket[ip].Send(newBytes);//发送给客户端，客户端在接收的时候根据首位标记判断如何处理数据

                //socketSend.Send(bytes);
            }
            catch { }
        }
        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            openFileDialog.Title = "请选择要发送的文件";
            openFileDialog.Filter = "所有文件|*.*";
            openFileDialog.ShowDialog();

            this.textBox5.Text = openFileDialog.FileName;
        }
        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //获得发送文件的路径
            string path = this.textBox5.Text;
            try
            {
                using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    byte[] byteFile = new byte[1024 * 1024 * 5];
                    int r = fsRead.Read(byteFile, 0, byteFile.Length);

                    List<byte> list = new List<byte>();
                    list.Add(1);
                    list.AddRange(byteFile);
                    byte[] newBytes = list.ToArray();

                    dicSocket[this.comboBox1.SelectedItem.ToString()].Send(newBytes, 0, r + 1, SocketFlags.None);
                }
            }
            catch { }
        }
        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            try
            {
                dicSocket[this.comboBox1.SelectedItem.ToString()].Send(buffer);
            }
            catch { }
         }
    }
}
