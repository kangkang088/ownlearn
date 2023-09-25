using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Test);
            //thread.IsBackground = true;
            thread.Start();
        }
        private void Test()
        {
            for (int i = 0; i < 10000; i++) { this.textBox1.Text = i.ToString(); }
        }
    }
}