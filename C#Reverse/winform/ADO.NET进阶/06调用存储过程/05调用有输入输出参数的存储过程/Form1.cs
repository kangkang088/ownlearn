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
            DBHelper.PrepareProc("proc_PwdUpdate");
            DBHelper.SetParameter("acc", this.textBox1.Text);
            DBHelper.SetOutAndInParameter("pwd", SqlDbType.VarChar, 20, this.textBox2.Text);
            DBHelper.ExecNonQuery();
            this.label3.Text = DBHelper.GetParameter("pwd").ToString();
        }
    }
}
