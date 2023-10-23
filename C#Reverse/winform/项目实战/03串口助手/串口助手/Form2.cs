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
    public partial class Form2 : Form {
        public TransmitData TransmitSend;
        public event TransmitDataEventHandler TransmitSend2;
        public Form2() {
            InitializeComponent();
        }
        //委托
        public void ReveiveData(byte[] tempData) {

            string str = Encoding.GetEncoding("gb2312").GetString(tempData);
            str = str.Replace("\0", "\\0");
            textBox1.AppendText(str);
        }
        //事件
        internal void receiveData2(object sender, TransmitEventArgs eventArgs) {
            string str = Encoding.GetEncoding("gb2312").GetString(eventArgs.data);
            str = str.Replace("\0", "\\0");
            textBox1.AppendText(str);
        }

        private void button1_Click(object sender, EventArgs e) {
            byte[] bytes = Encoding.GetEncoding("gb2312").GetBytes(textBox1.Text);
            TransmitSend?.Invoke(Encoding.GetEncoding("gb2312").GetBytes(textBox1.Text));//委托
            TransmitSend2?.Invoke(this, new TransmitEventArgs { data = bytes });//事件
        }
    }
}
