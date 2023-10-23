using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 绩效考核系统 {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            FrmUserManager frmUserManager = new FrmUserManager();
            frmUserManager.MdiParent = this;
            frmUserManager.Parent = this.splitContainer1.Panel2;
            frmUserManager.Show();
        }
    }
}
