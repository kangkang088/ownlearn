namespace _10PictureBox和Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Path.GetFullPath("C:\\Program Files"));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Pictures\\Camera Roll\\1.jpeg");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Administrator\\Pictures\\Camera Roll\\1.jpeg");
            pictureBox3.Image = Image.FromFile("C:\\Users\\Administrator\\Pictures\\Camera Roll\\1.jpeg");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Administrator\\Pictures\\Camera Roll\\1.jpeg");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Administrator\\Pictures\\Camera Roll\\1.jpeg");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Administrator\\Pictures\\Camera Roll\\1.jpeg");
        }
        string[] str = Directory.GetFiles("C:\\Users\\Administrator\\Pictures\\Camera Roll");
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //每隔一秒钟换一张图片
            i++;
            if (i == str.Length -1)
            { i = 0; }
            pictureBox1.Image = Image.FromFile(str[i]);
            pictureBox2.Image = Image.FromFile(str[i]);
            pictureBox3.Image = Image.FromFile(str[i]);
            pictureBox4.Image = Image.FromFile(str[i]);
            pictureBox5.Image = Image.FromFile(str[i]);
            pictureBox6.Image = Image.FromFile(str[i]);
            
        }
    }
}