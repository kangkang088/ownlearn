namespace _09PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Pictures\\Camera Roll\\1.jpeg");

        }
        //获得指定文件夹下所有文件的全路径
        string[] path = Directory.GetFiles("C:\\Users\\Administrator\\Pictures\\Camera Roll");
        int i = -1;

        private void button2_Click(object sender, EventArgs e)
        {

            if (i < path.Length - 2)
            {
                this.pictureBox1.Image = Image.FromFile(path[++i]);
            }
            else
            {
                i = 0;
                this.pictureBox1.Image = Image.FromFile(path[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                this.pictureBox1.Image = Image.FromFile(path[--i]);
            }
            else 
            { 
                i = path.Length - 2; 
                this.pictureBox1.Image = Image.FromFile(path[i]);
            }
        }
    }
}