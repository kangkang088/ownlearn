using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02C_直接调用没有参数的存储过程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BindData()
        {
            DBHelper.PrepareProc("proc_SelectMember");//直接填存储过程的名字就可以，因为sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure，会认为这是一个存储过程并执行。之前的认为是sql语句。
            this.dataGridView1.DataSource = DBHelper.ExecQuery();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
