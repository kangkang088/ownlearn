using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12ComBox下拉框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox2.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox2.Items.Clear();
            
        }
    }
}
