using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02绘制验证码并点击更换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string str = null;
            for (int i = 0; i < 5; i++)
            {
                int r = random.Next(0, 10);
                str += r;
            }
            //MessageBox.Show(str);
            //系统图片默认格式 位图
            Bitmap bmp = new Bitmap(120, 20);//宽度和高度
            //创建GDI对象,画图片
            Graphics graphics = Graphics.FromImage(bmp);//往位图（纸）上画内容
            //一次只能画一个，要画字符串长度次
            for (int i = 0; i < str.Length; i++)
            {
                Point point = new Point(i * 23, 0);//这个点是相对于picturebox的
                string[] strFont = { "楷体", "宋体", "微软雅黑" };
                Color[] colors = { Color.Brown, Color.Blue, Color.Red, Color.Black, Color.Green };
                graphics.DrawString(str[i].ToString(), new Font(strFont[random.Next(0, strFont.Length)], 15, FontStyle.Bold), new SolidBrush(colors[random.Next(0, colors.Length)]), point);
            }
            //设置影响视线的线
            for (int i = 0; i < 10; i++)
            {
                graphics.DrawLine(new Pen(Brushes.Black), new Point(random.Next(0, bmp.Width + 1), random.Next(0, bmp.Height)), new Point(random.Next(0, bmp.Width + 1), random.Next(0, bmp.Height)));
            }
            //加一些像素颗粒
            for (int i = 0; i < 50; i++)
            {
                Point p = new Point(random.Next(0, bmp.Width), random.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Red);
            }
            //将图片镶嵌到PictureBox中
            this.pictureBox1.Image = bmp;
        }
    }
}
