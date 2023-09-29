using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17委托实现窗体传值
{
    public delegate void DelTest(string name);
    public partial class Form2 : Form
    {
        public DelTest _del;
        public Form2(DelTest del)
        {
            this._del = del;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._del(this.textBox1.Text);
        }
    }
}
