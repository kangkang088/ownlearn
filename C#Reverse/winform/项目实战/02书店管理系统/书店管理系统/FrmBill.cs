using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 书店管理系统 {
    public partial class FrmBill : Form {
        public static string UserName;
        public FrmBill() {
            InitializeComponent();
        }
        //点击关闭
        private void label9_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //初始化表格
        private void BindData() {
            string sqlStr = "select* from Book";
            DBHelper.PrepareSql(sqlStr);
            DataTable dataTable = DBHelper.ExecQuery();
            this.dgvBook1.DataSource = dataTable;
        }
        //重置
        private void Reset() {
            this.bookname.Text = "";
            this.bookprice.Text = "";
            this.bookquantity.Text = "";
        }
        //初始化
        private void FrmBill_Load(object sender, EventArgs e) {
            this.dgvBook1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook1.AllowUserToAddRows = false;
            this.dgvBook2.AllowUserToAddRows = false;
            this.dgvBook1.ReadOnly = true;
            this.dgvBook2.ReadOnly = true;
            BindData();
            this.label8.Text = FrmBill.UserName;

        }
        //单击表格显示到文本框
        int key = 0,socket;
        private void dgvBook1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            this.bookname.Text = this.dgvBook1.SelectedRows[0].Cells[1].Value.ToString();
            this.bookprice.Text = this.dgvBook1.SelectedRows[0].Cells[5].Value.ToString();
            this.bookquantity.Text = "";
            key = int.Parse(this.dgvBook1.SelectedRows[0].Cells[0].Value.ToString());
            socket = int.Parse(this.dgvBook1.SelectedRows[0].Cells[4].Value.ToString());

        }
        //重置
        private void btnReset_Click(object sender, EventArgs e) {
            Reset();
        }
        //加入购物车
        static int n = 0;
        int endPrice = 0;
        private void btnAdd_Click(object sender, EventArgs e) {
            if (bookquantity.Text == "" || Convert.ToInt32(bookquantity.Text) > socket) {
                MessageBox.Show("库存不足或未输入数量");
            }
            else {
                int total = Convert.ToInt32(bookquantity.Text) * Convert.ToInt32(bookprice.Text);
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(this.dgvBook2);
                dataGridViewRow.Cells[0].Value = n + 1;
                dataGridViewRow.Cells[1].Value = bookname.Text;
                dataGridViewRow.Cells[2].Value = bookprice.Text;
                dataGridViewRow.Cells[3].Value = bookquantity.Text;
                dataGridViewRow.Cells[4].Value = total;
                this.dgvBook2.Rows.Add(dataGridViewRow);
                n++;
                update();
                endPrice += total;
                this.label7.Text ="订单总额：" +  endPrice.ToString() + "$";
            }
        }
        //结算并打印小票
        private void btnedit_Click(object sender, EventArgs e) {
            //将生成的交易信息加入订单表
            if (this.dgvBook2.Rows.Count == 0) {
                MessageBox.Show("您还未选择您所需的书籍");
                return;
            }
            try {
                string sqlStr = "insert into BillTable values(@UName,@Amount)";
                DBHelper.PrepareSql(sqlStr);
                DBHelper.SetParameter("UName", this.label8.Text);
                DBHelper.SetParameter("Amount", endPrice);
                int r = DBHelper.ExecNonQuery();
                if (r == 1) { MessageBox.Show("信息保存成功"); }
                BindData();
                Reset();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }   
            //纸张宽度和高度
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("print", 800, 800);
            //纸张打开就绘制
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.Print();
            }

        }
        int printID,printQuantity,printPrice,printToatl,pos = 60;

        private void label10_Click(object sender, EventArgs e) {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        string printName;
        //绘制小票
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            e.Graphics.DrawString("kangkangBookStore",new Font("幼圆",8,FontStyle.Bold),Brushes.Red,new Point(80));
            e.Graphics.DrawString("编号           产品             价格            数量             总计", new Font("幼圆", 10, FontStyle.Bold), Brushes.Black, new Point(26, 40));
            foreach (DataGridViewRow item in this.dgvBook2.Rows) { 
                printID = int.Parse(item.Cells[0].Value.ToString());
                printName = item.Cells[1].Value.ToString();
                printQuantity = int.Parse(item.Cells[2].Value.ToString());
                printPrice = int.Parse(item.Cells[3].Value.ToString());
                printToatl = int.Parse(item.Cells[4].Value.ToString());
                e.Graphics.DrawString("" + printID, new Font("幼圆", 8, FontStyle.Bold), Brushes.Red, new Point(0, pos));
                e.Graphics.DrawString("" + printName, new Font("幼圆", 8, FontStyle.Bold), Brushes.Red, new Point(20, pos));
                e.Graphics.DrawString("" + printQuantity, new Font("幼圆", 8, FontStyle.Bold), Brushes.Red, new Point(100, pos));
                e.Graphics.DrawString("" + printPrice, new Font("幼圆", 8, FontStyle.Bold), Brushes.Red, new Point(150, pos));
                e.Graphics.DrawString("" + printToatl, new Font("幼圆", 8, FontStyle.Bold), Brushes.Red, new Point(200, pos));
                pos += 60;
            }
            e.Graphics.DrawString("订单总额：$" + endPrice, new Font("幼圆", 12, FontStyle.Bold), Brushes.Red, new Point(50, pos));
            this.dgvBook2.Rows.Clear();
            this.dgvBook2.Refresh();
            pos = 60;
            endPrice = 0;
        }

        //更新库中的书籍总量
        private void update() {
            int newQuantity = socket - int.Parse(bookquantity.Text.ToString());
            try {
                string sqlStr1 = "update Book set @BQuantity = BQuantity where @BId = BId";
                DBHelper.PrepareSql(sqlStr1);
                DBHelper.SetParameter("BQuantity", newQuantity);
                DBHelper.SetParameter("BId", key);
                int r = DBHelper.ExecNonQuery();
                //if (r == 1) { MessageBox.Show("书籍数量更新成功。"); }
                BindData();
                Reset();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
