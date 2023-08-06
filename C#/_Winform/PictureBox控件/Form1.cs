using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 加载程序时显示图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //打开指定路径的指定图片
            pictureBox1.Image = Image.FromFile(@"C:\Users\Administrator\Downloads\acc7fa20c6c1a1e1e12d7c6152fcc345.jpeg");
        }
    }
}
