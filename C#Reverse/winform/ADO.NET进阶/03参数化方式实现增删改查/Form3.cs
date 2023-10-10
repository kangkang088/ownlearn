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
    public partial class Form3 : Form
    {
        public int MemId;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = "update Member set MemberAccount = @MemberAccount,MemberPwd = @MemberPwd,MemberName = @MemberName,MemberPhone = @MemberPhone where MemberId = @MemberId";
            SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@MemberAccount", this.textBox1.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@MemberPwd", this.textBox2.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@MemberName", this.textBox3.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@MemberPhone", this.textBox4.Text));
            sqlCommand.Parameters.Add(new SqlParameter("@MemberId", this.MemId));
            int rowCount = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("修改数据成功");
            }
            else
            {
                MessageBox.Show("修改数据失败");
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

        private void Form3_Load(object sender, EventArgs e)
        {
            if (this.MemId.ToString() == "")
            {

                MessageBox.Show("请正确选择行");
                return;

            }

            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = "select* from Member where MemberId = @MemberId";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, sqlConnection);
            sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@MemberId", this.MemId));
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("找不到会员");
                return;
            }
            this.textBox1.Text = dt.Rows[0]["MemberAccount"].ToString();
            this.textBox2.Text = dt.Rows[0]["MemberPwd"].ToString();
            this.textBox3.Text = dt.Rows[0]["MemberName"].ToString();
            this.textBox4.Text = dt.Rows[0]["MemberPhone"].ToString();

            sqlConnection.Close();
        }
    }
}
