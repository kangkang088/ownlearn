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
            Form form = FrmFactory<int>.CreatForm("FrmUserManager");

            //frmUserManager = new FrmUserManager();
            //frmUserManager.MdiParent = this;
            //frmUserManager.Parent = this.splitContainer1.Panel2;
            //frmUserManager.Show();

            //Form form = FrmFactory.CreatForm(0);
            form.MdiParent = this;
            form.Parent = this.splitContainer1.Panel2;
            form.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            foreach (TreeNode node in treeView1.Nodes) {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;
            Form form = FrmFactory<int>.CreatForm(e.Node.Tag.ToString());
            form.MdiParent = this;
            form.Parent = this.splitContainer1.Panel2;
            form.Show(); 
        }
    }
}
