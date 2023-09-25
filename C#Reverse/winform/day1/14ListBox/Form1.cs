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

namespace _14ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] str = Directory.GetFiles("C:\\Users\\Administrator\\Pictures\\Camera Roll", "*.jpeg");
        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.listBox1.Items.Add(1);
            this.listBox1.Items.Add(2);
            this.listBox1.Items.Add(3);
            
            for (int i = 0; i < str.Length; i++)
            {
                string fileName = Path.GetFileName(str[i]);
                this.listBox2.Items.Add(fileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(str[listBox2.SelectedIndex]);
        }
    }
}
