using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01GDI初识
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //画一条直线 
            //1.一支颜色笔 2.两个点 3.一张纸 4.绘制直线的人（GDI对象）

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.创建GDI对象(绘制直线的人)
            Graphics g = this.CreateGraphics(); //通过当前窗体(纸)创建对象
            //2.创建画笔的对象
            Pen p = new Pen(Brushes.Black);
            //3.创建点对象
            Point p1 = new Point(30, 30);
            Point p2 = new Point(300, 300);
            //4.开始画
            g.DrawLine(p, p1, p2);//把窗体拖到屏幕外面，直线会被擦掉，因为在移动过程中，窗体是系统创建的，它在循环画这个窗体，所有拖回来的时候
            //窗体还是完整的。但是我们的直线是我们通过上面的代码画出来的，只在点击的时候画一次，所有当我们把窗体拖出去再拖回来时，系统重画窗体
            //而直线被擦掉了。解决方法：设置窗体的Paint事件

        }
        int i = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            this.label1.Text = i.ToString();
            //1.创建GDI对象(绘制直线的人)
            Graphics g = this.CreateGraphics(); //通过当前窗体(纸)创建对象
            //2.创建画笔的对象
            Pen p = new Pen(Brushes.Black);
            //3.创建点对象
            Point p1 = new Point(30, 30);
            Point p2 = new Point(300, 300);
            //4.开始画
            g.DrawLine(p, p1, p2);//把窗体拖到屏幕外面，直线会被擦掉，因为在移动过程中，窗体是系统创建的，它在循环画这个窗体，所有拖回来的时候
            //窗体还是完整的。但是我们的直线是我们通过上面的代码画出来的，只在点击的时候画一次，所有当我们把窗体拖出去再拖回来时，系统重画窗体
            //而直线被擦掉了。解决方法：设置窗体的Paint事件
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Black);
            Rectangle rect = new Rectangle(new Point(50,50),new Size(50,50));
            graphics.DrawRectangle(pen, rect);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Black);
            Rectangle rectangle = new Rectangle(new Point(100,100), new Size(100,100));
            graphics.DrawPie(pen, rectangle, 60, 60);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font font = new Font("楷体", 25,FontStyle.Underline);
            g.DrawString("好好学习天天向上", font, Brushes.Black, new Point(300, 300));
        }
    }
}
