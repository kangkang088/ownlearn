using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10工具栏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("月底还没到，报表不能查看");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("欢迎来到****系统，现在是{0}",DateTime.Now.ToShortDateString());
        }
    }
}
