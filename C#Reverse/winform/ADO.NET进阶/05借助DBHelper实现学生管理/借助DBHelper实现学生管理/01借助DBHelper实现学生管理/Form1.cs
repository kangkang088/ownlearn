using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01借助DBHelper实现学生管理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 绑定下拉框信息
        /// </summary>
        private void BindPro()
        {
            DBHelper.PrepareSql("select* from ProfessionInfo");
            DataTable dt = new DataTable();
            dt = DBHelper.ExecQuery();
            DataRow dataRow = dt.NewRow();
            dataRow["ProfessionID"] = 0;
            dataRow["professionName"] = "-请选择-";
            dt.Rows.InsertAt(dataRow, 0);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "professionName";//要显示的内容
            this.comboBox1.ValueMember = "ProfessionID";//内容的值
        }
        /// <summary>
        /// 绑定学生信息
        /// </summary>
        private void BindData()
        {
            string sqlStr = "select* from StudentInfo inner join ProfessionInfo on StudentInfo.ProfessionID = ProfessionInfo.ProfessionID where 1 = 1";

            if (!this.comboBox1.SelectedValue.ToString().Equals("0"))
            {
                sqlStr += "and ProfessionInfo.ProfessionID = " + this.comboBox1.SelectedValue.ToString();
            }
            if (!this.textBox1.Text.Equals(""))
            {
                sqlStr += "and StuName like '%" + this.textBox1.Text + "%'";
            }
            DBHelper.PrepareSql(sqlStr);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = DBHelper.ExecQuery();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;
            BindPro();
            BindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确认删除？", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            else if (dialogResult == DialogResult.OK)
            {
                string memId = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string sqlStr = "delete from StudentInfo where StuID = @StuId";
                DBHelper.PrepareSql(sqlStr);
                DBHelper.SetParameter("StuId", memId);
                int rowCount = DBHelper.ExecNonQuery();
                if (rowCount == 1)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                BindData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this;
            form3.StuId = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            form3.Show();
        }
    }
}
