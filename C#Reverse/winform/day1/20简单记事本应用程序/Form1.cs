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

namespace _20简单记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.WordWrap = false;
            this.panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }
        List<string> strings = new List<string>();
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择要打开的文本文件";
            openFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "文本文件|*.txt";
            openFileDialog.ShowDialog();

            string path = openFileDialog.FileName;
            strings.Add(path);
            string fileName = Path.GetFileName(path);
            if (path == "") { return; }
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(bytes, 0, bytes.Length);
                this.textBox1.Text = Encoding.UTF8.GetString(bytes,0,r);
            }

            this.listBox1.Items.Add(fileName);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "请选择要保存的文本文件";
            saveFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            saveFileDialog.Filter = "文本文件|*.txt";
            saveFileDialog.ShowDialog();
            string str = saveFileDialog.FileName;
            if (str == "") { return; }
            using (FileStream fsWtirte = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(this.textBox1.Text);
                fsWtirte.Write(bytes, 0, bytes.Length);
            }
            MessageBox.Show("保存成功");
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text == "☆自动换行")
            {
                this.textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "☆取消自动换行";
            }
            else
            { 
                this.textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "☆自动换行";
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();    
            this.textBox1.Font = fontDialog.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            this.textBox1.ForeColor = colorDialog.Color;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string path = strings[this.listBox1.SelectedIndex];
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fsRead.Length];
                int r = fsRead.Read(bytes, 0, bytes.Length);
                this.textBox1.Text = Encoding.UTF8.GetString(bytes,0,r);
            }
        }
    }
}
