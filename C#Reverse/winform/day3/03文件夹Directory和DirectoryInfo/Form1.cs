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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            this.folderBrowserDialog1.ShowNewFolderButton = true;
            this.folderBrowserDialog1.Description = "请选择一个文件夹";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.textBox1.Text) || !Directory.Exists(this.textBox2.Text))
            {
                MessageBox.Show("文件夹不存在！");
                return;
            }
            string strName = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
            if (Directory.Exists(strName))//移动前判断目标文件夹是否已经存在
            {
                //1.
                //MessageBox.Show("文件夹已经存在");
                //return;
                //2. true表示 strName中有子文件时也强制删除 false（默认）只能删除空文件夹
                Directory.Delete(strName,true);
            }
            //move方法只支持在同一盘符下的操作
            Directory.Move(this.textBox1.Text, strName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.textBox1.Text))
            {
                MessageBox.Show("文件夹不存在！");
                return;
            }
            Directory.Delete(this.textBox1.Text, true);
        }
    }
}
