using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你思密达");
            this.Close();

        }        
        /// <summary>
        /// 当鼠标进入按钮的可见部分时，给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            //活动范围：窗体宽度-按钮宽度
            int x = this.ClientSize.Width - button2.ClientSize.Width;
            int y = this.ClientSize.Height - button2.ClientSize.Height;
            Random r = new Random();
            button2.Location = new Point(r.Next(0,x+1), r.Next(0,y+1));
        }
    }
}
