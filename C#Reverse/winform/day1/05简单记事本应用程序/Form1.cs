using System.Security.Policy;
using System.Text;

namespace _05简单记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnWorldWrap.Visible = false;
            this.btnSave.Visible = false;
            this.textBoxMain.Visible = false;
            this.textBoxMain.WordWrap = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxUserName.Text == "admin" && this.textBoxPassword.Text == "admin")
            {
                MessageBox.Show("登录成功");
                this.btnWorldWrap.Visible = true;
                this.btnSave.Visible = true;
                this.textBoxMain.Visible = true;
                this.textBoxUserName.Visible = false;
                this.textBoxPassword.Visible = false;
                this.btnLogin.Visible = false;
                this.labelUserName.Visible = false;
                this.labelPassword.Visible = false;
            }
            else
            {
                MessageBox.Show("登录失败");
                this.textBoxUserName.Text = "";
                this.textBoxPassword.Text = "";
                this.textBoxUserName.Focus();

            }
        }

        private void btnWorldWrap_Click(object sender, EventArgs e)
        {
            if (this.btnWorldWrap.Text == "自动换行")
            {
                this.textBoxMain.WordWrap = true;
                this.btnWorldWrap.Text = "取消自动换行";
            }
            else
            {
                this.textBoxMain.WordWrap = false;
                this.btnWorldWrap.Text = "自动换行";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream fsWrite = new FileStream("C:\\Users\\Administrator\\Desktop\\1808.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = this.textBoxMain.Text;
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                fsWrite.Write(bytes, 0, bytes.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}