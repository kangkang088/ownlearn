using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01调用exec语句执行存储过程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BindData()
        {
            DBHelper.PrepareSql("exec proc_SelectMember");
            DataTable dt = new DataTable();
            dt = DBHelper.ExecQuery();
            this.dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
