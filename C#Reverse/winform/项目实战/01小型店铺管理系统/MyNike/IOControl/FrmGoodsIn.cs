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
    public partial class FrmGoodsIn : Form
    {
        public FrmGoodsIn()
        {
            InitializeComponent();
        }
        //绑定类别
        private void BindPro()
        {
            DBHelper.PrepareSql("select* from [Type]");
            DataTable dataTable = DBHelper.ExecQuery();
            DataRow dataRow = dataTable.NewRow();
            dataRow["TypeID"] = "0";
            dataRow["TypeName"] = "--请选择--";
            dataTable.Rows.InsertAt(dataRow,0);
            this.comboBox1.DataSource = dataTable;
            this.comboBox1.DisplayMember = "TypeName";
            this.comboBox1.ValueMember = "TypeID";
            this.comboBox1.Text = "--请选择--";
        }
        private void FrmGoodsIn_Load(object sender, EventArgs e)
        {
            BindPro();
        }
        //取消
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //读取信息
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select* from Goods where BarCode = @BarCode";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("BarCode", this.textBox1.Text);
            DataTable dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count == 0) { MessageBox.Show("该商品为新商品！"); }
            else
            { 
                this.textBox2.Text = dataTable.Rows[0]["GoodsName"].ToString();
                this.comboBox1.SelectedValue = int.Parse(dataTable.Rows[0]["TypeID"].ToString());
                this.textBox3.Text = dataTable.Rows[0]["StorePrice"].ToString();
                this.textBox4.Text = dataTable.Rows[0]["SalePrice"].ToString();
                this.textBox5.Text = dataTable.Rows[0]["Discount"].ToString();
                
            }
        }
        //入库
        private void button2_Click(object sender, EventArgs e)
        {
            DBHelper.PrepareSql("select* from Goods where BarCode = @BarCode");
            DBHelper.SetParameter("BarCode", this.textBox1.Text);
            DataTable dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count == 0)
            {
                //新增
                string sql = "insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)\r\nvalues(@BarCode,@TypeID,@GoodsName,@StorePrice,@SalePrice,@Discount,@StockNum,getdate())";
                DBHelper.PrepareSql(sql);
                DBHelper.SetParameter("BarCode",this.textBox1.Text);
                DBHelper.SetParameter("TypeID", this.comboBox1.SelectedValue.ToString());
                DBHelper.SetParameter("GoodsName",this.textBox2.Text);
                DBHelper.SetParameter("StorePrice",this.textBox3.Text);
                DBHelper.SetParameter("SalePrice",this.textBox4.Text);
                DBHelper.SetParameter("Discount",this.textBox5.Text);
                DBHelper.SetParameter("StockNum",this.textBox6.Text);
                if (DBHelper.ExecNonQuery() == 1)
                {
                    MessageBox.Show("入库成功");
                }
                else { MessageBox.Show("入库失败"); }
            }
            else
            {
                //修改
                string sql = "update Goods set TypeID = @TypeID,GoodsName = @GoodsName,StorePrice = @StorePrice,SalePrice = @SalePrice,Discount = @Discount,StockNum = StockNum + @StockNum,StockDate = getdate() where BarCode = @BarCode";
                DBHelper.PrepareSql(sql);
                DBHelper.SetParameter("TypeID", this.comboBox1.SelectedValue.ToString());
                DBHelper.SetParameter("GoodsName", this.textBox2.Text);
                DBHelper.SetParameter("StorePrice", this.textBox3.Text);
                DBHelper.SetParameter("SalePrice", this.textBox4.Text);
                DBHelper.SetParameter("Discount", this.textBox5.Text);
                DBHelper.SetParameter("StockNum", this.textBox6.Text);
                DBHelper.SetParameter("BarCode", this.textBox1.Text);
                if (DBHelper.ExecNonQuery() == 1)
                {
                    MessageBox.Show("入库成功");
                }
                else { MessageBox.Show("入库失败"); }
            }
        }
    }
}
