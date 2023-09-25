using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25播放音乐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐";
            ofd.InitialDirectory = "C:\\Users\\Administrator\\Music";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.wav";
            ofd.ShowDialog();
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++) 
            {
                this.listBox1.Items.Add(Path.GetFileName(path[i]));
                list.Add(path[i]);
            }
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
            soundPlayer.SoundLocation = list[this.listBox1.SelectedIndex];
            soundPlayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //当前选中的索引
            int index = this.listBox1.SelectedIndex;
            index++;
            if (index == this.listBox1.Items.Count)
            {
                index = 0;
            }
            soundPlayer.SoundLocation = list[index];
            this.listBox1.SelectedIndex = index;
            soundPlayer.Play();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = this.listBox1.Items.Count - 1;
            }
            soundPlayer.SoundLocation = list[index];
            this.listBox1.SelectedIndex = (int)index;
            soundPlayer.Play();
        }
    }
}
