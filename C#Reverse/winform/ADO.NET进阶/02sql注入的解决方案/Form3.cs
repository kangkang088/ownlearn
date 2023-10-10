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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //方案三：参数化:取消原本的拼接形式的sqlStr，改为一个整体字符串，传参数。
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = "select* from Member where MemberAccount = @MemberAccount and MemberPwd = @MemberPwd";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@MemberAccount",this.textBox1.Text));
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@MemberPwd", this.textBox2.Text));
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
