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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void button3_Click(object sender, EventArgs e)
        {
            #region Directory类
            //if (!Directory.Exists(this.textBox1.Text) || !Directory.Exists(this.textBox2.Text))
            //{
            //    MessageBox.Show("文件夹不存在！");
            //    return;
            //}
            //string strName = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
            //if (Directory.Exists(strName))//移动前判断目标文件夹是否已经存在
            //{
            //    //1.
            //    //MessageBox.Show("文件夹已经存在");
            //    //return;
            //    //2. true表示 strName中有子文件时也强制删除 false（默认）只能删除空文件夹
            //    Directory.Delete(strName, true);
            //}
            ////move方法只支持在同一盘符下的操作
            //Directory.Move(this.textBox1.Text, strName);
            #endregion

            #region DirectoryInfo类
            try
            {
                DirectoryInfo directoryInfoStart = new DirectoryInfo(this.textBox1.Text);
                DirectoryInfo directoryInfoEnd = new DirectoryInfo(this.textBox2.Text);
                if (directoryInfoStart.Exists == false || directoryInfoEnd.Exists == false)
                {
                    MessageBox.Show("文件夹不存在");
                    return;
                }

                string strName = this.textBox2.Text + "\\" + Path.GetFileName(this.textBox1.Text);
                DirectoryInfo directoryInfoIsExist = new DirectoryInfo(strName);
                if (directoryInfoIsExist.Exists)
                {
                    //1.
                    //MessageBox.Show("文件已经存在，无法移动");
                    //return;
                    //2.
                    directoryInfoIsExist.Delete(true);
                }
                //只能移动相同盘符的操作
                directoryInfoStart.MoveTo(strName);
                MessageBox.Show("移动成功");
            }
            catch { MessageBox.Show("请先选择文件夹"); }
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region Directory类
            if (!Directory.Exists(this.textBox1.Text))
            {
                MessageBox.Show("文件夹不存在！");
                return;
            }
            Directory.Delete(this.textBox1.Text, true);
            #endregion

            #region DirectoryInfo类           
                DirectoryInfo directoryInfo = new DirectoryInfo(this.textBox1.Text);
                if(directoryInfo.Exists == false)
                {
                    MessageBox.Show("文件夹不存在");
                    return;
                }
                directoryInfo.Delete(true);
                MessageBox.Show("删除成功");          
            #endregion

        }
    }
}
