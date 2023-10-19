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
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }
        //进度条根据计时器推进
        private int startPos = 0;
        private void timer1_Tick(object sender, EventArgs e) {
            startPos += 1;
            this.MyProcess.Value = startPos;
            this.lblProcess.Text = startPos + "%";
            if (this.MyProcess.Value == 100) { 
                this.timer1.Stop();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            this.timer1.Start();

        }

        private void label3_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MyProcess_Click(object sender, EventArgs e) {

        }
    }
}
