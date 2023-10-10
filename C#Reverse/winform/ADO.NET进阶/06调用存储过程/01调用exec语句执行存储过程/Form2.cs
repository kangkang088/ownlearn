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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper.PrepareSql(string.Format("exec proc_InsertMember '{0}','{1}','{2}','{3}'",this.textBox1.Text,this.textBox2.Text,this.textBox3.Text,this.textBox4.Text));
            DBHelper.ExecNonQuery();
        }
    }
}
