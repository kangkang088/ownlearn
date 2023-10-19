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
    public partial class FrmUsersManager : Form {
        public FrmUsersManager() {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //初始化数据网格
        private void BindData() {
            string sqlStr = "select* from Users";
            DBHelper.PrepareSql(sqlStr);
            DataTable dataTable = DBHelper.ExecQuery();
            this.dataGridView1.DataSource = dataTable;
        }
        //将已输入的内容全部清空
        private void Reset() {
            this.userName.Text = "";
            this.uesePhone.Text = "";
            this.userAddress.Text = "";
            this.userPassword.Text = "";
        }
        //保存
        private void btnSave_Click(object sender, EventArgs e) {
            if (userName.Text == "" || uesePhone.Text == "" || userAddress.Text == "" || userPassword.Text == "") {
                MessageBox.Show("信息缺失，请填入完整信息后保存！");
                return;
            }
            try {
                string sqlStr = "insert into Users values(@UName,@UPhone,@UAdd,@UPassword)";
                DBHelper.PrepareSql(sqlStr);
                DBHelper.SetParameter("UName", this.userName.Text);
                DBHelper.SetParameter("UPhone", this.uesePhone.Text);
                DBHelper.SetParameter("UAdd", this.userAddress.Text);
                DBHelper.SetParameter("UPassword", this.userPassword.Text);
                int r = DBHelper.ExecNonQuery();
                if (r == 1) { MessageBox.Show("用户信息保存成功。"); }
                BindData();
                Reset();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //重置
        private void btnReset_Click(object sender, EventArgs e) {
            Reset();
        }
        //加载时初始化
        private void FrmUsersManager_Load(object sender, EventArgs e) {
            BindData();
        }
        //删除
        int key = 0;
        private void btnDelete_Click(object sender, EventArgs e) {
            //没选但是输入信息
            if (key == 0) {
                //输入的信息不全
                if (this.userName.Text == "" || this.uesePhone.Text == "" || this.userAddress.Text == "" || this.userPassword.Text == "") {
                    MessageBox.Show("信息缺失，请填入完整信息后删除！");
                    return;
                }
                //输入的信息全
                else {
                    try {
                        string sqlStr = "delete from Users where @UName = UName,@UPhone = UPhone,@UAdd = UAdd,@UPassword = UPassword";
                        DBHelper.PrepareSql(sqlStr);
                        DBHelper.SetParameter("UName", this.userName.Text);
                        DBHelper.SetParameter("UPhone", this.uesePhone.Text);
                        DBHelper.SetParameter("UAdd", this.userAddress.Text);
                        DBHelper.SetParameter("UPassword",this.userPassword.Text);
                        int r = DBHelper.ExecNonQuery();
                        if (r == 1) { MessageBox.Show("用户删除成功。"); } else { MessageBox.Show("用户不存在，无法删除。"); }
                        BindData();
                        Reset();

                    }
                    catch { }
                }
            }
            //选了，根据选的删
            try {
                string sqlStr = "delete from Users where UId = @UId";
                DBHelper.PrepareSql(sqlStr);
                DBHelper.SetParameter("UId", key);
                int r = DBHelper.ExecNonQuery();
                if (r == 1) { MessageBox.Show("用户删除成功。"); }
                BindData();
                Reset();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //点击单元格显示信息
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            this.userName.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.uesePhone.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.userAddress.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.userPassword.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //判断是否选中并返回书籍Id用于删除
            key = int.Parse(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }
        //编辑
        private void btnEdit_Click(object sender, EventArgs e) {
            if (key == 0) { MessageBox.Show("请先选择要编辑的用户。"); return; }
            if (userName.Text == "" || uesePhone.Text == "" || userAddress.Text == "" || userPassword.Text == "") {
                MessageBox.Show("信息缺失，请填入完整信息后再编辑！");
                return;
            }
            try {
                string sqlStr1 = "update Users set @UName = UName,@UPhone = UPhone,@UAdd = UAdd,@UPassword = UPassword where @UId = UId";
                DBHelper.PrepareSql(sqlStr1);
                DBHelper.SetParameter("UName", this.userName.Text);
                DBHelper.SetParameter("UPhone", this.uesePhone.Text);
                DBHelper.SetParameter("UAdd", this.userAddress.Text);
                DBHelper.SetParameter("UPassword", this.userPassword.Text.ToString());
                DBHelper.SetParameter("UId", key.ToString(""));
                int r = DBHelper.ExecNonQuery();
                if (r == 1) { MessageBox.Show("用户信息编辑成功。"); }
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

        private void label7_Click(object sender, EventArgs e) {
            
        }

        private void label6_Click(object sender, EventArgs e) {
            FrmBooksManager frmBooksManager = new FrmBooksManager();
            frmBooksManager.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e) {
            FrmAccountManager frmAccountManager = new FrmAccountManager();
            frmAccountManager.Show();
            this.Hide();
        }
    }
}
