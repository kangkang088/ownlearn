using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyNike.Basic
{
    public partial class FrmSaleMan : Form
    {
        public FrmSaleMan()
        {
            InitializeComponent();
        }
        //初始化性别下拉框
        private void BindComBox1()
        {
            this.comboBox1.Items.Add("--请选择--");
            this.comboBox1.Items.Add("男");
            this.comboBox1.Items.Add("女");
            this.comboBox1.Text = "--请选择--";
        }
        //初始化身份下拉框
        private void BindComBox2() 
        {
            this.comboBox2.Items.Add("--请选择--");
            this.comboBox2.Items.Add("店长");
            this.comboBox2.Items.Add("导购员");
            this.comboBox2.Items.Add("收银员");
            this.comboBox2.Text = "--请选择--";
        }
        //初始化员工信息表
        private void BindData()
        {
            DBHelper.PrepareSql("select* from SalesMan");
            this.dataGridView1.DataSource = DBHelper.ExecQuery();
        }
        private void FrmSaleMan_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.textBox3.UseSystemPasswordChar = true;
            BindComBox1();
            BindComBox2();
            BindData();
        }
        //添加员工
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])\r\nvalues(@SalesmanName,@Mobile,@Pwd,@Gender,@Wage,@CommissionRate,@Role)";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("SalesmanName", this.textBox1.Text);
            DBHelper.SetParameter("Mobile", this.textBox2.Text);
            DBHelper.SetParameter("Pwd", this.textBox3.Text);
            DBHelper.SetParameter("Gender", this.comboBox1.Text);
            DBHelper.SetParameter("Wage", this.textBox4.Text);
            DBHelper.SetParameter("CommissionRate", this.textBox5.Text);
            DBHelper.SetParameter("Role", this.comboBox2.Text);
            if (DBHelper.ExecNonQuery() == 1)
            {
                MessageBox.Show("添加成功");
                BindData();
            }
            else
                MessageBox.Show("添加失败");
        }
        //修改员工
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "update SalesMan set SalesmanName = @SalesmanName,Mobile = @Mobile,Pwd = @Pwd,Gender = @Gender,Wage = @Wage,CommissionRate = @CommissionRate,[Role] = @Role where SalesmanID = @SalesmanID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("SalesmanName", this.textBox1.Text);
            DBHelper.SetParameter("Mobile", this.textBox2.Text);
            DBHelper.SetParameter("Pwd", this.textBox3.Text);
            DBHelper.SetParameter("Gender", this.comboBox1.Text);
            DBHelper.SetParameter("Wage", this.textBox4.Text);
            DBHelper.SetParameter("CommissionRate", this.textBox5.Text);
            DBHelper.SetParameter("Role", this.comboBox2.Text);
            DBHelper.SetParameter("SalesmanID", int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            if(DBHelper.ExecNonQuery() == 1)
            {
                MessageBox.Show("修改成功");
                BindData();
            }
            else
                MessageBox.Show("修改失败");
        }
        //单击显示员工
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            string sql = "select* from SalesMan where SalesmanID = @SalesmanID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("SalesmanID", int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count != 1)
            {
                MessageBox.Show("获取不到数据!");
                BindData();
                return;
            }
            this.textBox1.Text = dataTable.Rows[0]["SalesmanName"].ToString();
            this.textBox2.Text = dataTable.Rows[0]["Mobile"].ToString();
            this.textBox3.Text = dataTable.Rows[0]["Pwd"].ToString();
            this.comboBox1.Text = dataTable.Rows[0]["Gender"].ToString();
            this.textBox4.Text = dataTable.Rows[0]["Wage"].ToString();
            this.textBox5.Text = dataTable.Rows[0]["CommissionRate"].ToString();
            this.comboBox2.Text = dataTable.Rows[0]["Role"].ToString();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                int id = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                string sql = "delete from SalesMan where SalesmanID = @SalesmanID";
                DBHelper.PrepareSql(sql);
                DBHelper.SetParameter("SalesmanID", id);
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
