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

namespace _01使用DataReader读取数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 初始列
            this.listView1.View = View.Details;
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();
            columnHeader1.Text = "编号";
            columnHeader1.Width = 150;
            columnHeader2.Text = "用户名";
            columnHeader2.Width = 150;
            columnHeader3.Text = "密码";
            columnHeader3.Width = 150;
            columnHeader4.Text = "昵称";
            columnHeader4.Width = 150;
            columnHeader5.Text = "电话";
            columnHeader5.Width = 150;
            this.listView1.Columns.Add(columnHeader1);
            this.listView1.Columns.Add(columnHeader2);
            this.listView1.Columns.Add(columnHeader3);
            this.listView1.Columns.Add(columnHeader4);
            this.listView1.Columns.Add(columnHeader5);
            #endregion

            #region 连接数据库，初始化数据
            //使用DataReader连接数据库
            //（1）.连接数据库
            //1.编写连接字符串（Windows方式 - 数据库和电脑在同一台电脑）
            string connStr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBONET;Data Source=.\r\n";

            //2.编写连接字符串（SQL server的用户名密码方式 - 通过网络）
            //string connStr = "server =.;database = DBONET;uid = sa;pwd = *****";

            //（2）.执行查询
            //1.创建连接对象，打开连接
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            //2.编写sql查询语句
            string sql = "SELECT* FROM Member";
            //3.执行sql语句
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();//一行一行读，返回SqlDataReader对象
            //（3）.读取
            //1.利用DataReader读取数据到控件
            while (sqlDataReader.Read())//读取一条数据，并且将位置移到下一行
            {
                
                ListViewItem item = new ListViewItem(sqlDataReader["MemberId"].ToString());
                item.SubItems.Add(sqlDataReader["MemberAccount"].ToString());
                item.SubItems.Add(sqlDataReader["MemberPwd"].ToString());
                item.SubItems.Add(sqlDataReader["MemberName"].ToString());
                item.SubItems.Add(sqlDataReader["MemberPhone"].ToString());
                this.listView1.Items.Add(item);
            }
            //2.关闭连接
            sqlDataReader.Close();


            //显示人数
            sqlCommand.CommandText = "select COUNT(*) from Member";
            int count = (int)sqlCommand.ExecuteScalar();
            this.label1.Text = "会员人数：" + count.ToString();

            conn.Close();
            #endregion
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
