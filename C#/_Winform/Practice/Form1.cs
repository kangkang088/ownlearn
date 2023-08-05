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

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 每隔一秒钟把当前时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// 窗体加载时也要显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //15:32 播放音乐
            if (DateTime.Now.Hour == 13 && DateTime.Now.Minute == 47 && DateTime.Now.Second == 40)
            {
                //播放音乐
                //SoundPlayer sp = new SoundPlayer();
                //sp.SoundLocation = @"路径";
                //sp.Play();
                MessageBox.Show("播放音乐");
            }
        }
    }
}
