using System.Diagnostics;

namespace _03TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text = textBox1.Text;
        }
    }
}