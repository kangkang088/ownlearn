using System.Reflection.Metadata.Ecma335;

namespace _07练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.rdoStudent.Checked || this.rdoTeacher.Checked)
            {
                string name = this.textBoxName.Text.Trim();
                string password = this.textBoxPassword.Text;
                if (this.rdoStudent.Checked)
                {
                    if (name == "student" && password == "student")
                    {
                        MessageBox.Show("登录成功");
                    }
                    else
                    {
                        this.textBoxName.Text = "";
                        this.textBoxPassword.Text = "";
                        this.textBoxName.Focus();
                        MessageBox.Show("登录失败");
                    }
                }
                else
                {
                    if (name == "teacher" && password == "teacher")
                    {
                        MessageBox.Show("登录成功");
                    }
                    else
                    {
                        this.textBoxName.Text = "";
                        this.textBoxPassword.Text = "";
                        this.textBoxName.Focus();
                        MessageBox.Show("登录失败");
                    }
                }
            }
            else { MessageBox.Show("请先选择登录身份"); }
        }
    }
}