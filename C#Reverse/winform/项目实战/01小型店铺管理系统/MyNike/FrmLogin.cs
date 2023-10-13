using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNike.IOControl;

namespace MyNike
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //点击登录，连接数据库
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals("") || this.textBox2.Text.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空");
                return;
            }
            string sql = "select* from SalesMan where Mobile = @Mobile and Pwd = @Pwd";
            DBHelper.PrepareSql(sql);
            DBHelper.SetParameter("Mobile", this.textBox1.Text);
            DBHelper.SetParameter("Pwd", this.textBox2.Text);
            DataTable dataTable = new DataTable();
            dataTable = DBHelper.ExecQuery();
            if (dataTable.Rows.Count == 1)
            {
                if (dataTable.Rows[0]["Role"].ToString().Equals("导购员"))
                { MessageBox.Show("只有店长和收银员可以登录系统"); return; }
                LoginConfig.SalesmanID = int.Parse(dataTable.Rows[0]["SalesmanID"].ToString());
                LoginConfig.SalesmanName = dataTable.Rows[0]["SalesmanName"].ToString();
                LoginConfig.Mobile = dataTable.Rows[0]["Mobile"].ToString();
                LoginConfig.Role = dataTable.Rows[0]["Role"].ToString();
                if (dataTable.Rows[0]["Role"].ToString().Equals("店长"))
                {
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                    this.Hide();
                    return;
                }
                if (dataTable.Rows[0]["Role"].ToString().Equals("收银员"))
                {
                    MessageBox.Show("收银员您好");
                    GetMoneyPlatform getMoneyPlatform = new GetMoneyPlatform();
                    getMoneyPlatform.StartPosition = FormStartPosition.CenterScreen;
                    getMoneyPlatform.Show();
                    this.Hide();
                    return;
                }
            }
            else
                MessageBox.Show("用户名或密码错误");

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
