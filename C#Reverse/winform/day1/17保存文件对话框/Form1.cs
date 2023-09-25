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

namespace _17保存文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "请选择要保存的路径";
            saveFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            saveFileDialog.Filter = "文本文件|*.txt";

            saveFileDialog.ShowDialog();

            //拿到保存文件的路径 全路径
            string str = saveFileDialog.FileName;
            if (str == "")
            {
                return;
            }
            using (FileStream fsWrite = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(this.textBox1.Text);
                fsWrite.Write(bytes, 0, bytes.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
