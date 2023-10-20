using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05可视化示例1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button3.Click += this.ButtonClicked;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            if (sender == button1)
                this.textBox1.Text = "Hello";
            if (sender == button2)
                this.textBox1.Text = "World";
            if (sender == button3)
                this.textBox1.Text = "Mr.Day";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
