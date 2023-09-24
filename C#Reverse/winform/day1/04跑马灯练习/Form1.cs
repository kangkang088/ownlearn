using Microsoft.VisualBasic;
using System.Media;
using System.Runtime.CompilerServices;

namespace _04跑马灯练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateAndTime.Now.ToString();
            if (DateAndTime.Now.Hour == 19 && DateAndTime.Now.Minute == 17)
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = "C:\\Users\\Administrator\\Desktop\\sound.wav";
                sound.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = DateAndTime.Now.ToString();
        }
    }
}