using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            this.openFileDialog1.Title = "打开文件";
            //文件筛选器
            this.openFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            //筛选器默认选择的项，从1开始
            this.openFileDialog1.FilterIndex = 2;
            //清空框内的默认内容
            this.openFileDialog1.FileName = null;
            //判断点击的是否是打开按钮，排除其他的操作
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                this.textBox1.Text = this.openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            this.saveFileDialog1.Title = "保存文件";
            this.saveFileDialog1.FilterIndex = 2;
            this.saveFileDialog1.FileName = null;
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.saveFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //title
            this.folderBrowserDialog1.Description = "请选择一个文件夹";
            //InitialDirectory
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            //指示新建文件夹按钮是否显示
            this.folderBrowserDialog1.ShowNewFolderButton = true;
            if(this.folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
                
            }
        }
    }
}
