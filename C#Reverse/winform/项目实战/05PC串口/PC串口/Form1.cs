using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC串口 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            for (int i = 0; i <= Byte.MaxValue; i++) { 
                string s = i.ToString("x").ToUpper();
                if (s.Length == 1) {
                    s = "0" + s;
                }
                comboBox1.Items.Add("0x" + s);
                
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string data = comboBox1.Text.Substring(2, 2);
            byte[] buffer = new byte[1];
            buffer[0] = Convert.ToByte(data);
            try {
                serialPort1.Open();
                serialPort1.Write(buffer, 0, buffer.Length);
                serialPort1.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
