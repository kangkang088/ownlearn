using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14图片集控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.imageList1.Images[0];
            this.button1.Enabled = false;
        }
        private int index = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            SetButtonEnable();
            this.pictureBox1.Image = this.imageList1.Images[(int)index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            SetButtonEnable();
            this.pictureBox1.Image = this.imageList1.Images[(int)index];
        }
        private void SetButtonEnable()
        {
            if (index == 0)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = true;
            }
            if (index == this.imageList1.Images.Count - 1)
            {
                this.button2.Enabled = false;
                this.button1.Enabled = true;
            }
        }
    }
}
