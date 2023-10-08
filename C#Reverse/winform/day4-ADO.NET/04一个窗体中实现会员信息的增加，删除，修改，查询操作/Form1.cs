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

namespace _04一个窗体中实现会员信息的增加_删除_修改_查询操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = "select* from Member";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStr, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = string.Format("insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)\r\n values('{0}','{1}','{2}','{3}')", this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text);
            SqlCommand cmd = new SqlCommand(sqlStr, sqlConnection);
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

            BindData();


        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Equals(""))
            {

                MessageBox.Show("请正确选择行");
                return;

            }
            //或者在属性AllowUserToAddRows改为false，最后一行空行就没有显示了
            //this.dataGridView1.AllowUserToAddRows = false;


            int memId = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = "delete from Member where MemberId = " + memId;
            SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlConnection);
            int rowCount = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("数据删除失败");
            }
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int memId = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = string.Format("update Member set MemberAccount = '{0}',MemberPwd = '{1}',MemberName = '{2}',MemberPhone = '{3}' where MemberId = {4}", this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, memId);
            SqlCommand sqlCommand = new SqlCommand(sqlStr,sqlConnection);
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
            BindData();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Equals(""))
            {

                MessageBox.Show("请正确选择行");
                return;

            }
            int memId = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = "select* from Member where MemberId = " + memId;
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
    }
}
