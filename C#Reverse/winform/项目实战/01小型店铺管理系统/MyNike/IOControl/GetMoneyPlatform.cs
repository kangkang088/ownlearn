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
    public partial class GetMoneyPlatform : Form
    {
        public GetMoneyPlatform()
        {
            InitializeComponent();
        }
        //关闭程序
        private void GetMoneyPlatform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //绑定数据
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
            //流水号
            this.lblNum.Text = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            //总金额
            this.lblSumMoney.Text = "共：￥ 0.00 元";
            //商品数量
            this.lblCount.Text = "商品数量：0";
            //收银员
            this.lblCasher.Text = "收银员：" + LoginConfig.SalesmanName;
            //应收
            this.txtShouldGet.Text = "0.00";
            //实收
            this.txtFinalGet.Text = "0.00";
            //找零
            this.txtSend.Text = "0.00";
        }
        private void GetMoneyPlatform_Load(object sender, EventArgs e)
        {
            BindControls();
            this.listView1.FullRowSelect = true;
        }
        //商品列表发生改变时，更新其他所有控件的值

        private void UpdateInfo()
        {
            double sumMone = 0;
            int sumCount = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                sumMone += int.Parse(item.SubItems[6].Text.ToString()) * double.Parse(item.SubItems[5].Text.ToString());
                sumCount += int.Parse(item.SubItems[6].Text.ToString());
            }
            this.lblSumMoney.Text = "共：￥" + sumMone.ToString("0.00") + "元";
            this.lblCount.Text = "商品数量：" + sumCount;
            this.txtShouldGet.Text = sumMone.ToString("0.00");
            this.txtSend.Text = (double.Parse(this.txtFinalGet.Text) - double.Parse(this.txtShouldGet.Text)).ToString();
        }
        //输入货号/条形码按回车更新数据
        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyCode = (int)e.KeyChar;
            if (keyCode != 13)//回车对应的整数值
            {
                return;
            }
            //如果列表中已经有该条形码信息，则按回车使数量+1
            foreach (ListViewItem item in this.listView1.Items)//每一行
            {
                if (this.txtBarCode.Text.Equals(item.Text))//每一行的Text就是每一行的第一列。其他列为subitem，下标从1开始
                {
                    int goodCount = int.Parse(item.SubItems[6].Text);
                    goodCount++;
                    item.SubItems[6].Text = goodCount.ToString();
                    //更新其他控件
                    UpdateInfo();
                    return;
                }
            }
            string sql = "select* from Goods inner join [Type] on [Type].TypeID = Goods.TypeID where BarCode = @BarCode";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("BarCode", this.txtBarCode.Text);
            DataTable dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("没有找到该商品");
                return;
            }
            ListViewItem listViewItem = new ListViewItem(dataTable.Rows[0]["BarCode"].ToString());
            listViewItem.SubItems.Add(dataTable.Rows[0]["GoodsName"].ToString());
            listViewItem.SubItems.Add(dataTable.Rows[0]["TypeName"].ToString());
            listViewItem.SubItems.Add(dataTable.Rows[0]["SalePrice"].ToString());
            listViewItem.SubItems.Add(dataTable.Rows[0]["Discount"].ToString());
            double salePrice = double.Parse(dataTable.Rows[0]["SalePrice"].ToString());
            double discount = double.Parse(dataTable.Rows[0]["Discount"].ToString());
            listViewItem.SubItems.Add(((salePrice * discount).ToString("0.00")));
            listViewItem.SubItems.Add("1");
            listViewItem.SubItems.Add(dataTable.Rows[0]["GoodsID"].ToString());
            this.listView1.Items.Add(listViewItem);
            UpdateInfo();
        }
        //按下+，数量+1；-，数量-1
        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(((int)e.KeyChar).ToString());//+：43 -：45 退格：8
            if (this.listView1.SelectedItems.Count == 0)
            { return; }
            int keyCode = (int)e.KeyChar;
            if (keyCode == 43)//+
            {
                int selectRowOfGoodCount = int.Parse(this.listView1.SelectedItems[0].SubItems[6].Text);
                selectRowOfGoodCount++;
                this.listView1.SelectedItems[0].SubItems[6].Text = selectRowOfGoodCount.ToString();

            }
            if (keyCode == 45)//-
            {
                int selectRowOfGoodCount = int.Parse(this.listView1.SelectedItems[0].SubItems[6].Text);
                if (selectRowOfGoodCount == 1) { return; }
                selectRowOfGoodCount--;
                this.listView1.SelectedItems[0].SubItems[6].Text = selectRowOfGoodCount.ToString();

            }
            if (keyCode == 8)//删除
            {
                this.listView1.SelectedItems[0].Remove();

            }
            UpdateInfo();
        }

        private void txtFinalGet_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyCode = (int)e.KeyChar;//必须强转，parse无法将字母形式的字符转换为数字
            if (keyCode != 13) { return; }
            this.txtSend.Text = (double.Parse(this.txtFinalGet.Text) - double.Parse(this.txtShouldGet.Text)).ToString("0.00");

        }
        //结算
        private void button1_Click(object sender, EventArgs e)
        {
            //账单表里添加数据
            DBHelper.PrepareSql("insert into Sales(ReceiptsCode,SalesDate,AllMoney,SalesmanID,CashierID)\r\nvalues(@ReceiptsCode,getdate(),@AllMoney,@SalesmanID,@CashierID) select @@identity");
            DBHelper.SetParameter("ReceiptsCode",this.lblNum.Text);
            DBHelper.SetParameter("AllMoney",this.txtShouldGet.Text);
            DBHelper.SetParameter("SalesmanID",this.comboBox1.SelectedValue.ToString());
            DBHelper.SetParameter("CashierID",LoginConfig.SalesmanID);
            int saleId = int.Parse(DBHelper.ExecScalar().ToString());
            //明细表里添加数据
            foreach (ListViewItem item in this.listView1.Items)
            {
                DBHelper.PrepareSql("insert into SalesDetail(SalesID,GoodsID,Quantity,GoodsMoney)\r\nvalues(@SalesID,@GoodsID,@Quantity,@GoodsMoney)");
                DBHelper.SetParameter("SalesID", saleId);
                DBHelper.SetParameter("GoodsID", item.SubItems[7].Text);
                DBHelper.SetParameter("Quantity", item.SubItems[6].Text);
                DBHelper.SetParameter("GoodsMoney", item.SubItems[5].Text);
                DBHelper.ExecNonQuery();
            }
            MessageBox.Show("结算成功");
            //重置数据
            this.txtBarCode.Text = "";
            this.listView1.Items.Clear();
            BindControls();
        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
