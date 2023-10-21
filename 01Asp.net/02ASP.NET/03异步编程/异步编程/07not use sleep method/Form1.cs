using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07not_use_sleep_method {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e) {
            using (HttpClient http = new HttpClient()) {
                string html1 = await http.GetStringAsync("http://www.baidu.com");
                textBox1.Text = html1.Substring(0,20);
                //Thread.Sleep(3000);//卡死
                await Task.Delay(3000);
                string htm2 = await http.GetStringAsync("http://www.youzack.com");
                textBox1.Text = htm2.Substring(0, 20);
            }
        }
    }
}
