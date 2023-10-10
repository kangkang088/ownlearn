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

namespace _03参数化方式实现增删改查
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlSteTest = "select* from Member where MemberAccount = @MemberAccount";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSteTest,sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@MemberAccount", this.textBox1.Text));
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("用户名已经存在");
                return;
            }
            string sqlStr = "insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)\r\n values(@MemberAccount,@MemberPwd,@MemberName,@MemberPhone)";
            SqlCommand cmd = new SqlCommand(sqlStr, sqlConnection);
            cmd.Parameters.Add(new SqlParameter("@MemberAccount", this.textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@MemberPwd", this.textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@MemberName", this.textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@MemberPhone", this.textBox4.Text));
            int rowCount = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("数据添加失败");
            }
            ((Form1)(this.Owner)).BindData();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
