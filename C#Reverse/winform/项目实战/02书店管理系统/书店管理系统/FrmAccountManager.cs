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
    public partial class FrmAccountManager : Form {
        public FrmAccountManager() {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e) {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void FrmAccountManager_Load(object sender, EventArgs e) {
            string sqlConn1 = "select sum(BQuantity) from Book";
            DBHelper.PrepareSql(sqlConn1);
            this.label3.Text = DBHelper.ExecScalar().ToString();
            string sqlConn2 = "select sum(Amount) from BillTable";
            DBHelper.PrepareSql(sqlConn2);
            this.label4.Text = DBHelper.ExecScalar().ToString();
            string sqlConn3 = "select count(*) from Users";
            DBHelper.PrepareSql(sqlConn3);
            this.label12.Text = DBHelper.ExecScalar().ToString();
        }

        private void label9_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e) {
            FrmUsersManager frmUsersManager = new FrmUsersManager();
            frmUsersManager.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e) {
            FrmBooksManager frmBooksManager = new FrmBooksManager();
            frmBooksManager.Show();
            this.Hide();
        }
    }
}
