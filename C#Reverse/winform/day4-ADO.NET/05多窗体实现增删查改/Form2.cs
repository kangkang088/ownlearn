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
            ((Form1)(this.Owner)).BindData();
            this.Close();
        }
    }
}
