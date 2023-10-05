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

namespace _02文件及文件夹操作
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.Description = "请选择一个文件夹";
            this.folderBrowserDialog1.ShowNewFolderButton = true;
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region File类
            //if (!File.Exists(this.textBox1.Text) || !Directory.Exists(this.textBox2.Text))
            //{
            //    MessageBox.Show("您选择的文件或文件夹不存在");
            //    return;
            //}
            //string strName = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
            ////true 允许覆盖
            //File.Copy(this.textBox1.Text, strName, true);
            #endregion

            #region FileInfo类
            FileInfo fileInfo = new FileInfo(this.textBox1.Text);
            DirectoryInfo directoryInfo = new DirectoryInfo(this.textBox2.Text);
            if ((fileInfo.Exists == false) || (directoryInfo.Exists == false))
            {
                MessageBox.Show("文件或文件夹不存在");
                return;
            }
            string strName = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
            fileInfo.CopyTo(strName,true);
            MessageBox.Show("复制成功");
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region File类
            //if (!File.Exists(this.textBox1.Text) || !Directory.Exists(this.textBox2.Text))
            //{
            //    MessageBox.Show("您选择的文件或文件夹不存在");
            //    return;
            //}
            //string strName = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
            ////开始移动之前进行判断，如果目标文件夹已经存在了这个要移动的文件
            //if (File.Exists(strName))
            //{
            //    //1.
            //    //MessageBox.Show("目标文件夹已经存在该文件");
            //    //return;
            //    //2.
            //    File.Delete(strName);
            //    return;
            //}
            //File.Move(this.textBox1.Text, strName);
            #endregion

            #region FileInfo类
            FileInfo fileInfo = new FileInfo(this.textBox1.Text);
            DirectoryInfo directoryInfo = new DirectoryInfo(this.textBox2.Text);
            if ((fileInfo.Exists == false) || (directoryInfo.Exists == false))
            {
                MessageBox.Show("文件或文件夹不存在");
                return;
            }
            string strName = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
            //移动前判读一下目标文件夹是否已经存在该移动的文件
            FileInfo fileInfo1 = new FileInfo(strName);
            if (fileInfo1.Exists == true)
            {
                //1.
                //MessageBox.Show("文件已经存在");
                //return;
                //2.
                fileInfo1.Delete();
            }
            fileInfo.MoveTo(strName);
            MessageBox.Show("移动成功");
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region File类
            //if (!File.Exists(this.textBox1.Text))
            //{
            //    MessageBox.Show("文件不存在");
            //    return;
            //}
            //File.Delete(this.textBox1.Text);
            //MessageBox.Show("删除成功");
            #endregion

            #region FileInfo类
            FileInfo fileInfo = new FileInfo(this.textBox1.Text);
            if (fileInfo.Exists == false)
            {
                MessageBox.Show("文件或文件夹不存在");
                return;
            }
            fileInfo.Delete();
            MessageBox.Show("删除成功");
            #endregion
        }
    }
}
