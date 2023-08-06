using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 老师或者学生
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdoStudent.Checked || rdoTeacher.Checked)
            {
                string name = textUserName.Text.Trim();
                string pass = textPassword.Text;
                if (rdoStudent.Checked)
                {
                    if (name == "student" && pass == "student")
                        MessageBox.Show("登录成功");
                    else
                    {
                        MessageBox.Show("登录失败");
                        textUserName.Clear();
                        textPassword.Clear();
                        textUserName.Focus();
                    }
                }
                else
                {
                    if (name == "teacher" && pass == "teacher")
                    {
                        MessageBox.Show("登录成功");
                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                        textUserName.Clear();
                        textPassword.Clear();
                        textUserName.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("请首先选择登录身份");
            }
            
        }
    }
}
