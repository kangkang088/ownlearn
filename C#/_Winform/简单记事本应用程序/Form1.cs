using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream file = new FileStream(@"C:\Users\Administrator\Desktop\save.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textWords.Text);
                file.Write(bytes, 0, bytes.Length);
                MessageBox.Show("保存成功");
            }
            
        }
        /// <summary>
        /// 当程序加载时，隐藏掉不需要的控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btnWordWrap.Visible = false;
            btnSave.Visible = false;
            textWords.Visible = false;
            //程序加载的时候，取消文本框的自动换行
            textWords.WordWrap = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textUserName.Text.Trim();
            string password = textPassword.Text;
            if (userName == "admin" && password == "123456")
            {
                MessageBox.Show("登录成功，欢迎使用简单记事本程序");
                label1.Visible = false;
                label2.Visible = false;
                textUserName.Visible = false;
                textPassword.Visible = false;
                btnLogin.Visible = false;
                btnRest.Visible = false;
                btnWordWrap.Visible = true;
                btnSave.Visible = true;
                textWords.Visible = true;
                textWords.Focus();
            }
            else
            {
                MessageBox.Show("用户名或者密码错误，请重新输入");
                textUserName.Clear();
                textPassword.Clear();
                textUserName.Focus();
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();
            textUserName.Focus();
        }
        /// <summary>
        /// 点击自动换行或者取消自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            if (btnWordWrap.Text == "自动换行")
            {
                textWords.WordWrap = true;
                btnWordWrap.Text = "取消自动换行";
                textWords.Focus();
            }
            else if(btnWordWrap.Text == "取消自动换行")
            {
                textWords.WordWrap = false;
                btnWordWrap.Text = "自动换行";
                textWords.Focus();
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
