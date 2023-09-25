using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.label2.Text = this.button1.Text;
            PlayGame(this.button1.Text);
        }

        private void PlayGame(string str)
        {
            Player player = new Player();
            int number1 = player.ShowFist(str);
            Computer computer = new Computer();
            int number2 = computer.ShowFist();
            this.label4.Text = computer.Fist;

            Result result = CaiPan.Judge(number1, number2);
            this.label6.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.button2.Text;
            PlayGame(this.button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.button3.Text;
            PlayGame(this.button3.Text);
        }
    }
}
