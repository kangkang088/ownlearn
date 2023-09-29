using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17委托实现窗体传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(ShowMessage);
            form2.Show();
        }
        /// <summary>
        /// 点击窗体2按钮，将内容赋值给窗体1的label，但是窗体1有方法没有值，窗体2有值没方法，用委托传递方法
        /// </summary>
        /// <param name="message"></param>
        void ShowMessage(string message) 
        {
            this.label1.Text = message;
        }
    }
}
