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

namespace 图片的切换和翻页效果
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\图片\1.jpeg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //操作文件夹的类   
        //获得指定文件夹的所有文件的全路径
        string[] files = Directory.GetFiles(@"C:\图片");

        /// <summary>
        /// 点击更换下一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            i++;
            if (i == files.Length)
            { 
                i= 0;
            }
            pictureBox1.Image = Image.FromFile(files[i]);


        }
        /// <summary>
        /// 点击上一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            { 
                i= files.Length-1;
            }
            pictureBox1.Image = Image.FromFile(files[i]);
        }
    }
}
