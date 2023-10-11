using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06掉用有返回值的存储过程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper.PrepareProc("proc_InsertMember");
            DBHelper.SetParameter("ACC", this.textBox1.Text);
            DBHelper.SetParameter("PWD", this.textBox2.Text);
            DBHelper.SetParameter("MMNAME", this.textBox3.Text);
            DBHelper.SetParameter("MMPHONE", this.textBox4.Text);
            DBHelper.ExecNonQuery();
        }
    }
}
