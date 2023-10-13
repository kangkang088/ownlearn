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
    public partial class FrmSalaryCalculate : Form
    {
        public FrmSalaryCalculate()
        {
            InitializeComponent();
        }
        //初始化日期
        private void BindTime()
        {
            DateTime dateTime = DateTime.Now;
            int day = dateTime.Day;
            if (this.comboBox1.Text.Equals("本月"))
            {
                this.dateTimePicker1.Value = dateTime.AddDays(-day + 1);
                this.dateTimePicker2.Value = dateTime.AddDays(-day + 1).AddMonths(1).AddDays(-1);
            }
            if (this.comboBox1.Text.Equals("上一月"))
            {
                this.dateTimePicker1.Value = dateTime.AddDays(-day + 1).AddMonths(-1);
                this.dateTimePicker2.Value = dateTime.AddDays(-day);
            }

        }
        //初始化工资信息
        private void BindData()
        {
            string sql = @"declare @AllSellMoney decimal(10,2)
            select @AllSellMoney = (select SUM(AllMoney) from Sales where SalesDate between @start and @end)
            if @AllSellMoney is null
	            set @AllSellMoney = 0
            select SalesmanName 姓名,[Role] 类型,Mobile 电话,Wage 基本工资,
            case
	            when [Role] = '收银员' then '0' 
	            else
	            CommissionRate
            end 提成比例,
            case
	            when [Role] = '店长' then @AllSellMoney
	            when sumMoney is null then 0
	            else sumMoney
            end 月销售额,
            case
	            when [Role] = '店长' then CONVERT(decimal(9,2),Wage + @AllSellMoney*CommissionRate)
	            when sumMoney is null then CONVERT(decimal(9,2),Wage)
	            else CONVERT(decimal(9,2),Wage + sumMoney * CommissionRate)
            end 应发工资 from SalesMan
            left join
            (select SalesmanID,SUM(AllMoney) sumMoney from Sales where SalesDate between @start and @end group by SalesmanID) ss
            on SalesMan.SalesmanID = ss.SalesmanID";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("start", this.dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            DBHelper.SetParameter("end", this.dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            this.dataGridView1.DataSource = DBHelper.ExecQuery();
        }
        private void FrmSalaryCalculate_Load(object sender, EventArgs e)
        {
            BindTime();
            BindData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindTime();
        }
        //点击核算
        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
