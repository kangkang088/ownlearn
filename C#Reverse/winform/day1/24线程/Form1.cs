using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread thread;
        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个新线程执行这个方法
             thread = new Thread(Test);
            //将线程设置为后台线程
            thread.IsBackground = true;
            //标记这个线程已经准备就绪，可以随时执行（给cpu信息说已经准备好了，由cpu决定什么时候执行这个线程）
            thread.Start();
            thread.Name = "Test";
            MessageBox.Show(thread.Name);
            
        }
        private void Test()
        { 
            for (int i = 0; i < 10000; i++) 
            { 
                //Console.WriteLine(i);
                //主线程是前台线程主窗口，test的线程是新建的后台线程，下面代码跨线程访问主线程里面的控件
                //可以通过关闭线程检查来解决
                this.textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程访问的检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗体时候，判断新线程是否为null，如果不为null，手动关闭线程
            if (thread != null)
            { 
                thread.Abort();
            }
        }
    }
}
