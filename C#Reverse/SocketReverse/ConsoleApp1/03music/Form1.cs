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

namespace _03music {
    public partial class Form1 : Form {
        public Form1(){
            InitializeComponent();
            this.listBox1.DoubleClick += listBox1_DoubleClick;
        }
        private List<string> _list = new List<string>();
        private void button1_Click(object sender, EventArgs e){
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择音乐";
            openFileDialog.InitialDirectory = "C:\\Users\\Administrator\\Desktop\\music";
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "音乐文件|*.wav|所有文件|*.*";
            openFileDialog.ShowDialog();
            string[] path = openFileDialog.FileNames;
            foreach (string s in path){
                this.listBox1.Items.Add(Path.GetFileName(s));
                _list.Add(s);
            }
        }
        private SoundPlayer soundPlayer;
        private void listBox1_DoubleClick(object sender, EventArgs e){
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = _list[this.listBox1.SelectedIndex];
            soundPlayer.Play();
        }
        private void button2_Click(object sender, EventArgs e){
            int index = this.listBox1.SelectedIndex;
            index++;
            if (index == this.listBox1.Items.Count){
                index = 0;
            }
            this.listBox1.SelectedIndex = index;
            soundPlayer.SoundLocation = _list[this.listBox1.SelectedIndex];
            soundPlayer.Play();
        }
        private void button3_Click(object sender, EventArgs e){
            int index = this.listBox1.SelectedIndex;
            index--;
            if (index < 0){
                index = this.listBox1.Items.Count - 1;
            }
            this.listBox1.SelectedIndex = index;
            soundPlayer.SoundLocation = _list[this.listBox1.SelectedIndex];
            soundPlayer.Play();
        }
    }
}