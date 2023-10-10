using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04实现DBHelper类
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)\r\n values(@MemberAccount,@MemberPwd,@MemberName,@MemberPhone)";
            DBHelper.PrepareSql(sqlStr);
            DBHelper.SetParameter("MemberAccount", this.textBox1.Text);
            DBHelper.SetParameter("MemberPwd", this.textBox2.Text);
            DBHelper.SetParameter("MemberName", this.textBox3.Text);
            DBHelper.SetParameter("MemberPhone", this.textBox4.Text);
            DBHelper.ExecNonQuery();
        }
    }
}
