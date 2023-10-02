using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02常用属性和事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello,my friends");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no,thanks");
        }

        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    MessageBox.Show("good bye");
        //}
        /// <summary>
        /// 在closed之前发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确定关闭此窗体吗？", "提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                //事件拦截
                e.Cancel = true;//取消窗体关闭
            }

            
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }
    }
}
