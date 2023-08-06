using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox和Timer的练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            //在窗体加载时，给每一个picturebox都赋值一个图片的路径
            pictureBox1.Image = Image.FromFile(@"C:\图片\1.jpeg");
            pictureBox2.Image = Image.FromFile(@"C:\图片\2.jpeg");
            pictureBox3.Image = Image.FromFile(@"C:\图片\3.jpeg");
            pictureBox4.Image = Image.FromFile(@"C:\图片\4.jpeg");
        }
        string[] allWay = System.IO.Directory.GetFiles(@"C:\图片");
        int i = 0;
        Random r = new Random();

        /// <summary>
        /// 每隔一秒钟换一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == allWay.Length)
            {
                i = 0;

            }
            pictureBox1.Image = Image.FromFile(allWay[r.Next(0, allWay.Length)]);
            pictureBox2.Image = Image.FromFile(allWay[r.Next(0, allWay.Length)]);
            pictureBox3.Image = Image.FromFile(allWay[r.Next(0, allWay.Length)]);
            pictureBox4.Image = Image.FromFile(allWay[r.Next(0, allWay.Length)]);
        }
    }
}
