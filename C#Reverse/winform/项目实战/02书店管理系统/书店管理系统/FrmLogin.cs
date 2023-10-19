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
    public partial class FrmLogin : Form {

        public FrmLogin() {
            InitializeComponent();
        }
        //点击关闭
        private void label9_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            string sqlConn = "select count(*) from Users where UName = @UName and UPassword = @UPassword";
            DBHelper.PrepareSql(sqlConn);
            DBHelper.SetParameter("UName", this.textBox1.Text);
            DBHelper.SetParameter("UPassword", this.textBox2.Text);
            DataTable dt = new DataTable();
            dt = DBHelper.ExecQuery();
            if (dt.Rows.Count == 1) {
                FrmBill frmBill = new FrmBill();
                FrmBill.UserName = this.textBox1.Text;
                frmBill.ShowDialog();
                this.Hide();
            }
            else { MessageBox.Show("用户名或密码错误"); }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
