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

namespace _03非查询操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 根据DataAdapter的command添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = string.Format("insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)\r\n values('{0}','{1}','{2}','{3}')", this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, sqlConnection);
            int rowCount = adapter.SelectCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("数据添加失败");
            }
        }
        /// <summary>
        /// 直接使用SqlCommand对象添加数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "server =.;database = DBONET;uid = sa;pwd = 08875799wei";
            SqlConnection sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
            string sqlStr = string.Format("insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)\r\n values('{0}','{1}','{2}','{3}')", this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text);
            SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlConnection);
            int rowCount = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("数据添加失败");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
