using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16系统托盘
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int index = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.imageList1.Images[0];
            this.button1.Enabled = false;
            this.notifyIcon1.Icon = new Icon("G:\\Thunder\\Program\\resources\\app\\static\\deskicon\\file.ico");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            IsEndIndex();
            this.pictureBox1.Image = this.imageList1.Images[(int)this.index];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            IsEndIndex();
            this.pictureBox1.Image = this.imageList1.Images[(int)this.index];
        }
        private void IsEndIndex()
        {
            if (this.index == this.imageList1.Images.Count - 1)
            {
                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
            if (this.index == 0)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = true;
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
