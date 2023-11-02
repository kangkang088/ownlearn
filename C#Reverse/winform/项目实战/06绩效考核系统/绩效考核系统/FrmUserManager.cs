using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace 绩效考核系统 {
    public delegate void DelBindDGV();
    public partial class FrmUserManager : Form {
        DelBindDGV delBindDGV;
        public FrmUserManager() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void FrmUserManager_Load(object sender, EventArgs e) {
            BindComBox();
            BindDGV();
            delBindDGV = BindDGV;
        }

        private void BindDGV() {
            string userName = textBox1.Text.Trim();
            int baseTypeId = int.Parse(comboBox1.SelectedValue.ToString());
            bool isStop = checkBox1.Checked;
            if (baseTypeId == 0) {
                dataGridView1.DataSource = UserAppraisalBases.GetListJoinAppraisal().FindAll(m => m.UserName.Contains(userName) && isStop == m.IsDel);
            }
            else {
                dataGridView1.DataSource = UserAppraisalBases.GetListJoinAppraisal().FindAll(m => m.UserName.Contains(userName) && m.BaseTypeId == baseTypeId && isStop == m.IsDel);
            }
        }

        private void BindComBox() {
            dataGridView1.AutoGenerateColumns = false;
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            appraisalBases.Add(new AppraisalBases { Id = 0, BaseType = "-查询所有-", AppraisalBase = 0, IsDel = false });
            appraisalBases.AddRange(AppraisalBases.ListAll());
            comboBox1.DataSource = appraisalBases;
            comboBox1.DisplayMember = "BaseType";
            comboBox1.ValueMember = "Id";
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            BindDGV();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                tsmAdd.Visible = true;
                tsmEdit.Visible = false;
                tsmStart.Visible = false;
                tsmStop.Visible = false;
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            dataGridView1.MultiSelect = false;
            if (e.Button == MouseButtons.Right) {
                if (e.RowIndex > -1) {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    tsmAdd.Visible = true;
                    tsmEdit.Visible = true;
                    bool isDel = (bool)dataGridView1.SelectedRows[0].Cells["IsDel"].Value;
                    if (isDel) {
                        tsmStart.Visible = true;
                    }
                    else {
                        tsmStop.Visible = true;
                    }
                }
            }
        }

        private void tsmAdd_Click(object sender, EventArgs e) {
            FrmSetUser frmSetUser = new FrmSetUser(delBindDGV);
            frmSetUser.ShowDialog();
        }

        private void tsmEdit_Click(object sender, EventArgs e) {
            int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            FrmSetUser frmSetUser = new FrmSetUser(delBindDGV, id);
            frmSetUser.ShowDialog();
        }
    }
}
