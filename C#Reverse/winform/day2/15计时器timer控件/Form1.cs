using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15计时器timer控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm::ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm::ss");
        }
    }
}
