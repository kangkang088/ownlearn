using Models;
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
    public partial class FrmBaseManager : Form {
        public FrmBaseManager() {
            InitializeComponent();
        }

        private void FrmBaseManager_Load(object sender, EventArgs e) {
            dataGridView1.DataSource = AppraisalBases.ListAll();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            //AppraisalBases appraisal = (AppraisalBases)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //AppraisalBases.Update(appraisal);
        }
    }
}
