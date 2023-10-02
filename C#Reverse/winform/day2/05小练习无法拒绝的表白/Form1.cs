using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05小练习无法拒绝的表白
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("就知道你喜欢我！");
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断用户关闭窗口的原因是点击窗体右上角的叉号
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MessageBox.Show("就算关闭也改变不了你喜欢我的事实");
                e.Cancel = true;
            }
            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (this.button2.Text == "不是")
            {
                this.button2.Text = "是的";
                this.button1.Text = "不是";
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (this.button1.Text == "不是")
            {
                this.button1.Text = "是的";
                this.button2.Text = "不是";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("就知道你喜欢我！");
            Application.Exit();
        }
    }
}
