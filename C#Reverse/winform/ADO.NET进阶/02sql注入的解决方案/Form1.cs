using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02sql注入的解决方案
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //方案一：排除危险字符单引号
            if (this.textBox1.Text.IndexOf("'") >= 0 || this.textBox2.Text.IndexOf("'") >= 0)
            {
                MessageBox.Show("非法登录");
                return;
            }
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = string.Format("select* from Member where MemberAccount = '{0}' and MemberPwd = '{1}'", this.textBox1.Text, this.textBox2.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("用户名或密码错误");
            }
            else
            {
                MessageBox.Show("登录成功");
            }
        }
    }
}
