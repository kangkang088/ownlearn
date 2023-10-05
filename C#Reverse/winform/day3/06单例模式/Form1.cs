using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06单例模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 普通模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void 单例模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = Form3.GetSingleForm3();
            form3.MdiParent = this;
            form3.Show();
        }
    }
}
