using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 书店管理系统 {
    public partial class FrmBooksManager : Form {
        public FrmBooksManager() {
            InitializeComponent();
        }
        //初始化数据网格
        private void BindData() {
            string sqlStr = "select* from Book";
            DBHelper.PrepareSql(sqlStr);
            DataTable dataTable = DBHelper.ExecQuery();
            this.dgvBook.DataSource = dataTable;
        }
        //按条件初始化数据网格
        private void BindDataByCat() {
            string sqlStr = "select* from Book where BCat = @BCat";
            DBHelper.PrepareSql(sqlStr);
            DBHelper.SetParameter("BCat", this.txtCatChoice.SelectedItem.ToString());
            DataTable dataTable = DBHelper.ExecQuery();
            this.dgvBook.DataSource = dataTable;
        }
        //将已输入的内容全部清空
        private void Reset() {
            this.txtBookName.Text = "";
            this.txtAuthorName.Text = "";
            this.txtCat.Text = "";
            this.txtQuantity.Text = "";
            this.txtPrice.Text = "";
        }
        //点击关闭
        private void label9_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //点击保存
        private void btnSave_Click(object sender, EventArgs e) {
            if (txtBookName.Text == "" || txtAuthorName.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "" || this.txtCat.Text.ToString() == "全部分类") {
                MessageBox.Show("信息缺失，请填入完整信息后保存！");
                return;
            }
            try {
                if (this.txtCat.Text == "") { MessageBox.Show("请输入书籍分类"); return; }
                string sqlStr = "insert into Book values(@Btitle,@BAuthor,@BCat,@BQuantity,@BPrice)";
                DBHelper.PrepareSql(sqlStr);
                DBHelper.SetParameter("Btitle", this.txtBookName.Text);
                DBHelper.SetParameter("BAuthor", this.txtAuthorName.Text);
                DBHelper.SetParameter("BCat", this.txtCat.SelectedItem.ToString());
                DBHelper.SetParameter("BQuantity", int.Parse(this.txtQuantity.Text));
                DBHelper.SetParameter("BPrice", int.Parse(this.txtPrice.Text));
                int r = DBHelper.ExecNonQuery();
                if (r == 1) { MessageBox.Show("书籍信息保存成功。"); }
                BindData();
                Reset();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //选定行输入信息填入上方信息框中
        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //this.txtBookName.Text = this.dgvBook.SelectedRows[0].Cells[1].Value.ToString();
            this.txtBookName.Text = this.dgvBook.SelectedRows[0].Cells[1].Value.ToString();
            this.txtAuthorName.Text = this.dgvBook.SelectedRows[0].Cells[2].Value.ToString();
            this.txtCat.SelectedItem = this.dgvBook.SelectedRows[0].Cells[3].Value.ToString();
            this.txtQuantity.Text = this.dgvBook.SelectedRows[0].Cells[4].Value.ToString();
            this.txtPrice.Text = this.dgvBook.SelectedRows[0].Cells[5].Value.ToString();
            //判断是否选中并返回书籍Id用于删除
            key = int.Parse(this.dgvBook.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void FrmBooksManager_Load(object sender, EventArgs e) {
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.txtCat.Items.Add("儿童读物");
            this.txtCat.Items.Add("文学艺术");
            this.txtCat.Items.Add("人文历史");
            this.txtCat.Items.Add("生活美食");
            this.txtCat.Items.Add("经济管理");
            this.txtCat.Items.Add("科学技术");
            this.txtCat.Text = "全部分类";
            BindData();
        }
        //按类型显示信息
        private void txtCatChoice_SelectedIndexChanged(object sender, EventArgs e) {
            BindDataByCat();
        }
        //更新（重新显示全部数据）
        private void btnUpdate_Click(object sender, EventArgs e) {
            BindData();
            this.txtCatChoice.Text = "";
        }
        //重置
        private void btnReset_Click(object sender, EventArgs e) {
            Reset();
        }
        //点击删除
        int key = 0;
        private void btnDelete_Click(object sender, EventArgs e) {
            //没选但是输入信息
            if (key == 0) {
                //输入的信息不全
                if (this.txtBookName.Text == "" || this.txtAuthorName.Text == "" || this.txtCat.Text == "" || this.txtCat.Text == "全部分类" || this.txtQuantity.Text == "" || this.txtPrice.Text == "") {
                    MessageBox.Show("信息缺失，请填入完整信息后删除！");
                    return;
                }
                //输入的信息全
                else {
                    try {
                        string sqlStr = "delete from Book where @BTitle = BTitle,@BAuthor = BAuthor,@BCat = BCat,@BQuantity = BQuantity,@BPrice = BPrice";
                        DBHelper.PrepareSql(sqlStr);
                        DBHelper.SetParameter("BTitle", this.txtBookName.Text);
                        DBHelper.SetParameter("BAuthor", this.txtAuthorName.Text);
                        DBHelper.SetParameter("BCat", this.txtCat.SelectedItem.ToString());
                        DBHelper.SetParameter("BQuantity", int.Parse(this.txtQuantity.Text));
                        DBHelper.SetParameter("BPrice", this.txtPrice.Text);
                        int r = DBHelper.ExecNonQuery();
                        if (r == 1) { MessageBox.Show("书籍删除成功。"); } else { MessageBox.Show("书籍不存在，无法删除。"); }
                        BindData();
                        Reset();

                    }
                    catch { }
                }
            }
            //选了，根据选的删
            try {
                string sqlStr = "delete from Book where BId = @BId";
                DBHelper.PrepareSql(sqlStr);
                DBHelper.SetParameter("BId", key);
                int r = DBHelper.ExecNonQuery();
                if (r == 1) { MessageBox.Show("书籍删除成功。"); }
                BindData();
                Reset();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //点击编辑
        private void btnEdit_Click(object sender, EventArgs e) {
            if (key == 0) { MessageBox.Show("请先选择要编辑的书籍。"); return; }
            if (txtBookName.Text == "" || txtAuthorName.Text == "" || txtQuantity.Text == "" || txtPrice.Text == "" || txtCat.SelectedItem.ToString() == "") {
                MessageBox.Show("信息缺失，请填入完整信息后保存！");
                return;
            }
            try {
                string sqlStr1 = "update Book set @BTitle = BTitle,@BAuthor = BAuthor,@BCat = BCat,@BQuantity = BQuantity,@BPrice = BPrice where @BId = BId";
                DBHelper.PrepareSql(sqlStr1);
                DBHelper.SetParameter("BTitle", this.txtBookName.Text);
                DBHelper.SetParameter("BAuthor", this.txtAuthorName.Text);
                DBHelper.SetParameter("BCat", this.txtCat.SelectedItem.ToString());
                DBHelper.SetParameter("BQuantity", int.Parse(this.txtQuantity.Text));
                DBHelper.SetParameter("BPrice", int.Parse(this.txtPrice.Text));
                DBHelper.SetParameter("BId", key.ToString());
                int r = DBHelper.ExecNonQuery();
                if (r == 1) { MessageBox.Show("书籍信息编辑成功。"); }
                BindData();
                Reset();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label10_Click(object sender, EventArgs e) {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e) {
            
        }

        private void label7_Click(object sender, EventArgs e) {
            FrmUsersManager frmUsersManager = new FrmUsersManager();
            frmUsersManager.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e) {
            FrmAccountManager frmAccountManager = new FrmAccountManager();
            frmAccountManager.Show();
            this.Hide();
        }
    }
}
