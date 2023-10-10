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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //方案二：只查询用户名，在数据库中得到对应的密码，然后和文本框中的密码进行比对
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = string.Format("select* from Member where MemberAccount = '{0}'", this.textBox1.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("用户名错误");
            }
            else
            {
                if (dataTable.Rows[0]["MemberPwd"].ToString().Equals(this.textBox2.Text))
                {
                    MessageBox.Show("登录成功");
                }
                else MessageBox.Show("密码错误");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
