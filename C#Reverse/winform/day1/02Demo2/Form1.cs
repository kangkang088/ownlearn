namespace _02Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;

            int weight = random.Next(0, x + 1);
            int height = random.Next(0, y + 1);
            button2.Location = new Point(weight, height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这都能点到？");
            this.Close();
        }
    }
}