using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNike.DataStudy
{
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }
        //绑定导购员下拉框
        private void BindControls()
        {
            //导购员下拉框
            DBHelper.PrepareSql("select* from SalesMan where [Role] = '导购员'");
            DataTable dataTable = DBHelper.ExecQuery();
            DataRow dataRow = dataTable.NewRow();
            dataRow["SalesmanID"] = "0";
            dataRow["SalesmanName"] = "--请选择--";
            dataTable.Rows.InsertAt(dataRow, 0);
            this.comboBox1.DataSource = dataTable;
            this.comboBox1.DisplayMember = "SalesmanName";
            this.comboBox1.ValueMember = "SalesmanID";
        }
        //绑定时间
        private void BindTime()
        {
            if (this.comboBox2.Text.Equals("本日"))
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                DateTime dateTimebegin = DateTime.Now;
                this.dateTimePicker1.Value = dateTimebegin;
                this.dateTimePicker2.Value = dateTimebegin;
            }
            if (this.comboBox2.Text.Equals("本周"))
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                DateTime dateTime = DateTime.Now;//日期和时间

                int dayOfWeek = (int)DateTime.Now.DayOfWeek;//当前星期几
                if (dayOfWeek == 0) dayOfWeek = 7;

                this.dateTimePicker1.Value = dateTime.AddDays(-dayOfWeek + 1);//星期一
                this.dateTimePicker2.Value = dateTime.AddDays(7 - dayOfWeek);//星期日
            }
            if (this.comboBox2.Text.Equals("本月"))
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                DateTime dateTime = DateTime.Now;

                int dayOfMonth = (int)DateTime.Now.Day;//几号
                this.dateTimePicker1.Value = dateTime.AddDays(-dayOfMonth + 1);//1号
                this.dateTimePicker2.Value = dateTime.AddDays(-dayOfMonth + 1).AddMonths(1).AddDays(-1);//本月最后一天
            }
            if (this.comboBox2.Text.Equals("本年"))
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;
                DateTime dateTime = DateTime.Now;

                int dayOfYear = (int)DateTime.Now.DayOfYear;//本年的第几天
                this.dateTimePicker1.Value = dateTime.AddDays(-dayOfYear + 1);//本年第一天
                this.dateTimePicker2.Value = dateTime.AddDays(-dayOfYear + 1).AddYears(1).AddDays(-1);//本年最后一天
            }
        }
        //初始化列表数据
        private void BindData()
        {
            string sql = @"select ReceiptsCode 流水号,SalesDate 购物日期,AllMoney 购物金额,
            lirun 单笔利润,
            DaoGouMan.SalesmanName 导购员,CashierMan.SalesmanName 收银员 from Sales 
            left join SalesMan DaoGouMan on DaoGouMan.SalesmanID = Sales.SalesmanID 
            left join SalesMan CashierMan on  Sales.CashierID = CashierMan.SalesmanID
            left join (select SalesID,SUM((GoodsMoney - StorePrice)*Quantity) lirun from SalesDetail left join Goods on SalesDetail.GoodsID = Goods.GoodsID group by SalesID) liruntable on Sales.SalesID = liruntable.SalesID
            where SalesDate between @begin and @end";
            if (this.comboBox1.SelectedValue.ToString() != "0")
            {
                sql += " and Sales.SalesmanID = " + this.comboBox1.SelectedValue.ToString();
            }
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("begin",this.dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            DBHelper.SetParameter("end", this.dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            this.dataGridView1.DataSource = dataTable;
            this.label4.Text = "销售记录:" + dataTable.Rows.Count + "条";
            double sumSales = 0.00;//销售金额
            double realSalary = 0.00;//利润金额
            foreach (DataRow row in dataTable.Rows ) 
            {
                sumSales += double.Parse(row["购物金额"].ToString());
                realSalary += double.Parse(row["单笔利润"].ToString());
            }
            this.label5.Text = "销售金额：￥" + sumSales + "元，利润：￥" + realSalary + "。"; 

        }
        private void FrmSales_Load(object sender, EventArgs e)
        {
            BindControls();
            BindTime();
            BindData();
        }
        //改变时间后更新
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
