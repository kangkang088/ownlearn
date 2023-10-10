using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04调用有输入参数和输出参数的存储过程
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
            DBHelper.PrepareProc("proc_GetInfoBYAcc");
            DBHelper.SetParameter("ACC", this.textBox1.Text);//输入参数
            DBHelper.SetOutParameter("MEMNAME", SqlDbType.VarChar, 20);//输出参数
            DBHelper.SetOutParameter("MEMPHONE", SqlDbType.VarChar, 20);
            DBHelper.ExecNonQuery();
            this.label2.Text = DBHelper.GetParameter("MEMNAME").ToString();
            this.label3.Text = DBHelper.GetParameter("MEMPHONE").ToString();
        }
    }
}
