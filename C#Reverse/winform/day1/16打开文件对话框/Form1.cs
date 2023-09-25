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

namespace _16打开文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击弹出对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置属性
            //标题
            ofd.Title = "请选择要打开的文本文件";
            //多选
            ofd.Multiselect = true;
            //初识目录
            ofd.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            //文件类型
            ofd.Filter = "文本文件|*.txt";
            ofd.ShowDialog(this);

            //获得在对话框中选中文件的路径 全路径
            
            string path = ofd.FileName;
            if (path == "")
            {
                return;
            }
            
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[1024 * 1024 * 5];
                int num = fsRead.Read(bytes, 0, bytes.Length);
                this.textBox1.Text = Encoding.UTF8.GetString(bytes, 0, num);
            }
        }
    }
}
