using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
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
        }
        void ShowMessage(string str)
        { 
            this.textBox3.AppendText(str + "\r\n");
        }
    }
}
