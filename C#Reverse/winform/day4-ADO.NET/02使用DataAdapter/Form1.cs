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

namespace _02使用DataAdapter
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
            string connStr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBONET;Data Source=.\r\n";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = "SELECT* FROM Member";

            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);//从数据库里面查询sqlStr，然后填充到内存中的dt中

            this.dataGridView1.DataSource = dt;

            adapter.SelectCommand.CommandText = "select COUNT(*) from Member";
            int count = (int)adapter.SelectCommand.ExecuteScalar();
            this.label1.Text = "会员人数：" + count.ToString();

            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBONET;Data Source=.\r\n";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = "select* from Member";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //添加
            DataRow dataRow = dt.NewRow();
            dataRow["MemberAccount"] = "liudehua";
            dataRow["MemberPwd"] = "123456";
            dataRow["MemberName"] = "刘德华";
            dataRow["MemberPhone"] = "155648465354";
            dt.Rows.Add(dataRow);
            //修改密码
            dt.Rows[1]["MemberPwd"] = "654321";//行数下标从0开始，第二行是1
            //删除第四行
            dt.Rows[3].Delete();

            //回写到数据库
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(dt);         
            sqlConnection.Close();

            BindData();
            MessageBox.Show("数据更新成功");
        }
    }
}
