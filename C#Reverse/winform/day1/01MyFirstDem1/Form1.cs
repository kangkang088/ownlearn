namespace _01MyFirstDem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sender �����¼��Ķ���
            Button btn = (Button)sender;
            MessageBox.Show("Hello World!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test.form1 = this;
        }
    }
}