using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串口助手 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //begin when form has loaded
        private void Form1_Load(object sender, EventArgs e) {
        }
        private void btnOpenPort_Click(object sender, EventArgs e) {
            try {
                if (port_ComBox.Text != "") {
                    serialPort1.PortName = port_ComBox.Text;
                }
                serialPort1.Open();
                if (serialPort1.IsOpen) {
                    MessageBox.Show("Serialport has opened successfully!!!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + serialPort1.PortName.ToString());
            }
        }
    }
}
