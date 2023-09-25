using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27线程和进程复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //进程 Process  一个进程包括多个线程
            //Process.GetProcesses  获取当前程序的所有进程
            //Process.Start("应用程序") 通过进程打开应用程序

            //通过进程打开指定文件
            //ProcessStartInfo processStartInfo = new ProcessStartInfo("路径");
            //Process process = new Process();
            //process.StartInfo = processStartInfo;
            //process.Start();

            //线程 Thread  
            //单线程容易造成程序假死

            //Thread.CurrentThread
            
        }
    }
}
