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

namespace _04读写文本文件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1.FileName = null;
            this.textBox2.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Administrator\\Desktop";
            this.openFileDialog1.FilterIndex = 1;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.openFileDialog1.FileName;
            }
            else
            {
                return;
            }
            //显示文本内容
            #region 方案一：FileStream将文件一次性读取到字节数组，然后转换为字符串
            //using (FileStream fsRead = new FileStream(this.textBox1.Text, FileMode.Open, FileAccess.Read))
            //{
            //    byte[] bytes = new byte[(int)fsRead.Length];
            //    int r = fsRead.Read(bytes, 0, bytes.Length);
            //    this.textBox2.Text = Encoding.Default.GetString(bytes,0,r);
            //}
            #endregion

            #region 方案二：FileStream将文件逐字节读取到字节数组，然后转换为字符串
            //using (FileStream fsRead = new FileStream(this.textBox1.Text, FileMode.Open, FileAccess.Read))
            //{
            //    byte[] bytes = new byte[fsRead.Length];
            //    int index = 0;
            //    int code = fsRead.ReadByte(); //如果code == -1，读完
            //    while (code != -1)
            //    {
            //        bytes[index] = Convert.ToByte(code);
            //        code = fsRead.ReadByte();
            //        index++;
            //    }
            //    this.textBox2.Text = Encoding.UTF8.GetString(bytes);
            //}
            #endregion

            #region 方案三：File静态类
            //this.textBox2.Text = File.ReadAllText(this.textBox1.Text,Encoding.UTF8);
            #endregion

            #region 方案四：StreamReader流读取器
            using (FileStream fsRead = new FileStream(this.textBox1.Text, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fsRead, Encoding.UTF8))
                {
                    //while (!streamReader.EndOfStream)
                    //{
                    // this.textBox2.Text += streamReader.ReadLine() + "\r\n";
                        
                    //}
                    this.textBox2.Text = streamReader.ReadToEnd();
                }
            }

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region 方案一：File静态类
            //File.WriteAllText(this.textBox1.Text,this.textBox2.Text,Encoding.Default);
            #endregion

            #region 方案二：StreamWriter流写入器
            using (FileStream fsWrite = new FileStream(this.textBox1.Text, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fsWrite, Encoding.Default))
                {
                    streamWriter.Write(this.textBox2.Text);
                    MessageBox.Show("保存成功");
                }
            }
            #endregion
        }
    }
}
