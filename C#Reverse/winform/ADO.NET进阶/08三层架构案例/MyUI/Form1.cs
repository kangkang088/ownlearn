using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyEntity;
using MyBLL;

namespace MyUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProfessionBLL proBLL = new ProfessionBLL();
        StudentInfoBLL stuBLL = new StudentInfoBLL();
        private void BindProfession()
        {
            List<ProfessionInfoEntity> list = new List<ProfessionInfoEntity>();
            list = proBLL.List();
            list.Insert(0, new ProfessionInfoEntity { ProfessionInfoID = 0, ProfessionName = "--请选择--" });
            this.comboBox1.DataSource = list;
            this.comboBox1.DisplayMember = "ProfessionName";
            this.comboBox1.ValueMember = "ProfessionInfoID";
        }
        private void BindData()
        {
            StudentInfoEntity studentInfo = new StudentInfoEntity();
            studentInfo.ProfessionID = int.Parse(this.comboBox1.SelectedValue.ToString());
            studentInfo.StuName = this.textBox1.Text;
            this.dataGridView1.DataSource = stuBLL.Search(studentInfo);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            BindProfession();
            BindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;
            int count = stuBLL.Delete(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            if (count == 1) MessageBox.Show("删除成功");
            else MessageBox.Show("删除失败");
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StuId = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            form3.Show();
        }
    }
}
