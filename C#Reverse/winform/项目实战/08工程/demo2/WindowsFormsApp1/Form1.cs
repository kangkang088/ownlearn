using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        private SerialPort serialPort = null;
        private ModbusSerialMaster serialMaster = null;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            serialPort = new SerialPort("COM1", 9600);
            serialPort.Open();
            serialMaster = ModbusSerialMaster.CreateRtu(serialPort);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (serialPort.IsOpen) { 
                serialPort.Close();
            }
        }
    }
}
