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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
        }
        internal void BindData()
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
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this;
            form3.MemId = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//单击整行选中
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;//绑定菜单
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
            string sqlStr = "delete from Member where MemberId = @MemberId";
            SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@MemberId", memId));
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
    }
}
