using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01倒计时器 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            for (int i = 0; i < 100; i++) {
                comboBox1.Items.Add((i + 1).ToString() + " 秒");
            }
        }
        int avg;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            label2.Text = comboBox1.SelectedItem.ToString();
            string s = label2.Text.ToString();
            s = s.Substring(0, s.Length - 1).Trim();
            avg = 100 / int.Parse(s);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex >= 0) {
                timer1.Start();
            }
            else {
                MessageBox.Show("请先选择计时时间");
            }
        }
        int startPos = 0;
        int max = 0;
        private void timer1_Tick(object sender, EventArgs e) {
            string s = label2.Text.ToString();
            s = s.Substring(0, s.Length - 1).Trim();
            max = int.Parse(s);
            startPos += avg;
            max--;
            label2.Text = max.ToString() + "秒";
            
            progressBar1.Value = startPos;
            if (max == 0) {
                timer1.Stop();
                MessageBox.Show("计时完成");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            timer1.Stop();
        }
    }
}
