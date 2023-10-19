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
    public partial class AdminLogin : Form {
        public AdminLogin() {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (this.textBox2.Text == "password") {
                MessageBox.Show("管理员登录成功");
                FrmBooksManager frmBooksManager = new FrmBooksManager();
                frmBooksManager.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("密码错误");
            }
        }

        private void label1_Click(object sender, EventArgs e) {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
