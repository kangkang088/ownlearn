using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show("转换成功");
        }
        /// <summary>
        /// 弹出窗体2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //在内存中创建窗体2对象
            Form2 form = new Form2();
            form.Show();
        }
        /// <summary>
        /// 当加载窗体的时候，将窗体对象放到Class1类中的静态字段中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Class1._form1 = this;
        }
    }
}
