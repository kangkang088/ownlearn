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

namespace _03文件夹Directory和DirectoryInfo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }
        /// <summary>
        /// 递归实现文件夹的复制
        /// </summary>
        /// <param name="startFolderPath">原始文件夹路径</param>
        /// <param name="endFolderPath">目标文件夹路径,是一个处理之后的路径（经过是否存在判断和拼接）</param>
        private void CopyFolder(string startFolderPath, string endFolderPath)
        {
            //目标盘创建需要复制的其他盘的文件夹
            Directory.CreateDirectory(endFolderPath);
            //循环赋值文件夹内的所有文件
            DirectoryInfo startDirectoryInfo = new DirectoryInfo(startFolderPath);
            foreach (FileInfo item in startDirectoryInfo.GetFiles())
            {
                item.CopyTo(endFolderPath + "\\" + item.Name);
            }
            //循环所有的子目录，递归调用
            foreach (DirectoryInfo item in startDirectoryInfo.GetDirectories())
            {
                string startPath = item.FullName;
                string endPath = endFolderPath + "\\" + item.Name;
                CopyFolder(startPath, endPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.textBox1.Text) || !Directory.Exists(this.textBox2.Text))
            {
                MessageBox.Show("文件夹不存在");
                return;
            }
            string endPath = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
            DirectoryInfo directoryInfo = new DirectoryInfo(endPath);
            if (directoryInfo.Exists)
            {
                //1.
                //MessageBox.Show("目标地址已经存在同名文件夹");
                //return;
                //2.
                directoryInfo.Delete();
            }
            CopyFolder(this.textBox1.Text, endPath);
            MessageBox.Show("复制成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.textBox1.Text) || !Directory.Exists(this.textBox2.Text))
            {
                MessageBox.Show("文件夹不存在");
                return;
            }
            string endPath = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
            DirectoryInfo directoryInfo = new DirectoryInfo(endPath);
            if (directoryInfo.Exists)
            {
                //1.
                //MessageBox.Show("目标地址已经存在同名文件夹");
                //return;
                //2.
                directoryInfo.Delete();
            }
            CopyFolder(this.textBox1.Text, endPath);
            Directory.Delete(this.textBox1.Text,true);
            MessageBox.Show("移动成功");
        }
    }
}
