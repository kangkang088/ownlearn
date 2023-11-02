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
    public partial class FrmUserAppraisal : Form {
        public FrmUserAppraisal() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void FrmUserAppraisal_Load(object sender, EventArgs e) {
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
            List<DataGridViewTextBoxColumn> dataGridTextBoxColumns = new List<DataGridViewTextBoxColumn>();
            foreach (var appraisalCoefficient in appraisalCoefficients) {
                dataGridTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                    HeaderText = appraisalCoefficient.AppraisalType.ToString(),
                    Name = "AppraisalType" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "AppraisalType" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Width = 88
                });
                dataGridTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                    HeaderText = "系数",
                    Name = "AppraisalCoefficient"  + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "AppraisalCoefficient" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Width = 88
                });
                dataGridTextBoxColumns.Add(new DataGridViewTextBoxColumn {
                    HeaderText = "计算方式",
                    Name = "CalculationMethod" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "CalculationMethod" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Width = 88
                });
            }
            dataGridView1.Columns.AddRange(dataGridTextBoxColumns.ToArray());
        }
    }
}
