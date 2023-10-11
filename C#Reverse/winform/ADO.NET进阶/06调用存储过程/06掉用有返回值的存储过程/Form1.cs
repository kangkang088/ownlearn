using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06掉用有返回值的存储过程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.PrepareProc("proc_NewInsertMember");
                DBHelper.SetParameter("acc", this.textBox1.Text);
                DBHelper.SetParameter("pwd", this.textBox2.Text);
                DBHelper.SetParameter("name", this.textBox3.Text);
                DBHelper.SetParameter("phone", this.textBox4.Text);
                DBHelper.SetReturnParameter("returnValue");
                DBHelper.ExecNonQuery();
                int result = (int)DBHelper.GetParameter("returnValue");
                if (result == 1)
                    MessageBox.Show("添加成功");
            }
            catch (Exception ex)
            {
                int result = (int)DBHelper.GetParameter("returnValue");
                if (result == -1)
                    MessageBox.Show("用户名重名");
                else if (result == -100)
                    MessageBox.Show(ex.Message);
            }

        }
    }
}
