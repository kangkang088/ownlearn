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

namespace _05多窗体实现增删查改
{
    public partial class Form3 : Form
    {
        public int MemId { get; set; }
        public Form3()
        {
            InitializeComponent();
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
            string sqlStr = "select* from Member where MemberId = " + this.MemId;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, sqlConnection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = string.Format("update Member set MemberAccount = '{0}',MemberPwd = '{1}',MemberName = '{2}',MemberPhone = '{3}' where MemberId = {4}", this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.MemId);
            SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlConnection);
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
    }
}
