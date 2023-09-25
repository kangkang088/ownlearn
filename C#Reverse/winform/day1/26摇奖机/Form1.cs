using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Test);
            thread.IsBackground = true;
            thread.Start("123");
        }
        private void Test(object s)
        { 
            for (int i = 0; i < 100000; i++) { Console.WriteLine(i); }
        }
    }
}
