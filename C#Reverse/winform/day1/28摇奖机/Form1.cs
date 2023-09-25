using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        bool b = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                b = true;
                this.button1.Text = "暂停";
                Thread thread = new Thread(PlayGame);
                thread.IsBackground = true;
                thread.Start();
            }
            else { b = false;this.button1.Text = "开始"; }
            
        }
        private void PlayGame()
        {
            Random random = new Random();
            while (b)
            {
                this.label1.Text = random.Next(0, 10).ToString();
                this.label2.Text = random.Next(0, 10).ToString();
                this.label3.Text = random.Next(0, 10).ToString();

            }
        }
    }
}
