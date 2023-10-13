using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNike.Basic;
using MyNike.IOControl;
using MyNike.DataStudy;

namespace MyNike
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //结束程序
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //初始化界面
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.lbltime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
            this.lblwelcome.Text = LoginConfig.SalesmanName + LoginConfig.Role + ",欢迎您!";
        }
        //显示时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbltime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }
        //启动商品分类
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmType frmType = new FrmType();
            frmType.MdiParent = this;
            frmType.StartPosition = FormStartPosition.CenterScreen;
            frmType.Show();
        }
        //启动员工管理
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmSaleMan frmSaleMan = new FrmSaleMan();
            frmSaleMan.MdiParent = this;
            frmSaleMan.StartPosition = FormStartPosition.CenterScreen;
            frmSaleMan.Show();
        }
        //商品浏览
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmGoodsView frmGoodsView  = new FrmGoodsView();
            frmGoodsView.MdiParent = this;
            frmGoodsView.StartPosition = FormStartPosition.CenterScreen;
            frmGoodsView.Show();
        }
        //商品入库
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmGoodsIn frmGoodsIn = new FrmGoodsIn();
            frmGoodsIn.MdiParent = this;
            frmGoodsIn.StartPosition = FormStartPosition.CenterScreen;
            frmGoodsIn.Show();
        }
        //弹出收银台，不需要设置mdi
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GetMoneyPlatform getMoneyPlatform = new GetMoneyPlatform();
            getMoneyPlatform.StartPosition = FormStartPosition.CenterScreen;
            getMoneyPlatform.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmSalaryCalculate frmSalaryCalculate = new FrmSalaryCalculate();
            frmSalaryCalculate.MdiParent = this;
            frmSalaryCalculate.StartPosition = FormStartPosition.CenterScreen;
            frmSalaryCalculate.Show();
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FrmSales frmSales = new FrmSales();
            frmSales.MdiParent = this;
            frmSales.StartPosition = FormStartPosition.CenterScreen;
            frmSales.Show();
        }
    }
}
