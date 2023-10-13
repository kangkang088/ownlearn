using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNike.IOControl
{
    public partial class FrmGoodsView : Form
    {
        public FrmGoodsView()
        {
            InitializeComponent();
        }
        //绑定商品分类下拉框
        private void BindType()
        {
            DBHelper.PrepareSql("select* from [Type]");
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            DataRow dataRow = dataTable.NewRow();
            dataRow["TypeName"] = "--请选择--";
            dataRow["TypeID"] = "0";
            dataTable.Rows.InsertAt(dataRow, 0);
            this.comboBox4.DataSource = dataTable;
            this.comboBox4.DisplayMember = "TypeName";
            this.comboBox4.ValueMember = "TypeID";
        }
        //根据条件，查询商品
        private void BindData()
        {
            string sql = "select* from Goods inner join [Type] on Goods.TypeID = [Type].TypeID where 1 = 1";
            //根据商品条形码/货号
            if (!this.textBox1.Text.Equals("")) sql += "and BarCode = '" + this.textBox1.Text.Trim() + "'";
            //根据商品名称
            if(!this.textBox2.Text.Equals("")) sql += "and GoodsName like '%" + this.textBox2.Text + "%'";
            //根据日期
            if (!this.comboBox3.Text.Equals("全部")) sql += string.Format("and StockDate between '{0}' and '{1}'", this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00", this.dateTimePicker2.Value.ToString("yyyy-MM-dd") + " 23:59:59");
            //根据类别
            if (!this.comboBox4.SelectedValue.ToString().Equals("0")) sql += "and Goods.TypeID = " + this.comboBox4.SelectedValue.ToString();
            DBHelper.PrepareSql(sql);
            DataTable dataTable = DBHelper.ExecQuery();
            this.label6.Text = "当前共" + dataTable.Rows.Count + "条记录";
            this.dataGridView1.DataSource = dataTable;
        }
        private void FrmGoodsView_Load(object sender, EventArgs e)
        {
            BindType();
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AutoGenerateColumns = false;
            BindData();
        }
        //初始化日期下拉框
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox3.Text.Equals("全部"))
            {
                this.dateTimePicker1.Enabled = false;
                this.dateTimePicker2.Enabled = false;
            }
            if (this.comboBox3.Text.Equals("本日"))
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                DateTime dateTimebegin = DateTime.Now;
                this.dateTimePicker1.Value = dateTimebegin;
                this.dateTimePicker2.Value = dateTimebegin;
            }
            if (this.comboBox3.Text.Equals("本周"))
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                DateTime dateTime = DateTime.Now;//日期和时间

                int dayOfWeek = (int)DateTime.Now.DayOfWeek;//当前星期几
                if (dayOfWeek == 0) dayOfWeek = 7;

                this.dateTimePicker1.Value = dateTime.AddDays(-dayOfWeek + 1);//星期一
                this.dateTimePicker2.Value = dateTime.AddDays(7 - dayOfWeek);//星期日
            }
            if (this.comboBox3.Text.Equals("本月"))
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                DateTime dateTime = DateTime.Now;

                int dayOfMonth = (int)DateTime.Now.Day;//几号
                this.dateTimePicker1.Value = dateTime.AddDays(-dayOfMonth + 1);//1号
                this.dateTimePicker2.Value = dateTime.AddDays(-dayOfMonth + 1).AddMonths(1).AddDays(-1);//本月最后一天
            }
            if (this.comboBox3.Text.Equals("本年"))
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                DateTime dateTime = DateTime.Now;

                int dayOfYear = (int)DateTime.Now.DayOfYear;//本年的第几天
                this.dateTimePicker1.Value = dateTime.AddDays(-dayOfYear + 1);//本年第一天
                this.dateTimePicker2.Value = dateTime.AddDays(-dayOfYear + 1).AddYears(1).AddDays(-1);//本年最后一天
            }
        }
        //点击查询
        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
