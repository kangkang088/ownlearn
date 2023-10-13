using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNike.Basic
{
    public partial class FrmType : Form
    {
        public FrmType()
        {
            InitializeComponent();
        }
        //初始化列表数据
        private void BindData()
        {
            DBHelper.PrepareSql("select* from [Type]");
            this.dataGridView1.DataSource = DBHelper.ExecQuery();
        }
        private void FrmType_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            BindData();
        }
        //添加类型
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into [Type](TypeName) values(@TypeName)";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("TypeName", this.textBox1.Text);
            if (DBHelper.ExecNonQuery() == 1)
            {
                MessageBox.Show("添加成功");
                BindData();
            }
            else
                MessageBox.Show("添加失败");
        }
        //修改类型
        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string sql = "update [Type] set TypeName = @TypeName where TypeId = @TypeId";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("TypeName", this.textBox1.Text);
            DBHelper.SetParameter("TypeId", id);
            if (DBHelper.ExecNonQuery() == 1)
            {
                MessageBox.Show("修改成功");
                BindData();
            }
            else MessageBox.Show("修改失败");
        }
        //获取当前选中行并显示
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DBHelper.PrepareSql("select* from [Type] where TypeId = @TypeId");
            DBHelper.SetParameter("TypeId", id);
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count != 1)
            {
                MessageBox.Show("获取不到数据!");
                BindData();
                return;
            }
            this.textBox1.Text = dataTable.Rows[0]["TypeName"].ToString();
        }
        //删除行
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                int id = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string sql = "delete from [Type] where TypeId = @TypeId";
                DBHelper.PrepareSql(sql);
                DBHelper.SetParameter("TypeId", id);
                if (DBHelper.ExecNonQuery() == 1)
                {
                    MessageBox.Show("删除成功");
                    BindData();
                }
                else MessageBox.Show("删除失败");
            }
            else return;
        }
    }
}
