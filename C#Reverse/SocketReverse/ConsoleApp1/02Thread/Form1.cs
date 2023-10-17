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

namespace _02Thread {
    public partial class Form1 : Form {
        public Form1(){
            InitializeComponent();
            this.button1.Click += button1_Click;
        }
        private Thread thread;
        private void button1_Click(object sender, EventArgs e){
            //创建一个线程去执行这个方法
            thread = new Thread(Test);
            thread.IsBackground = true;
            thread.Start(); //标记线程为准备就绪的状态，什么时候执行，由cpu决定（如果很忙，依然无法执行）。人为最大权限为标记这个准备状态。
        }
        private void Test(){
            for (int i = 0; i < 10000000; i++){
                this.textBox1.Text = i.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e){
            //取消跨线程访问检测
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e){
            if (thread != null){
                //结束线程
                thread.Abort();//无法再重新Start了，彻底死亡
                
            }
        }
    }
}