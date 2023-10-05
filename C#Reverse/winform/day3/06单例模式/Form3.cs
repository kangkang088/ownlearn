using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06单例模式
{
    public partial class Form3 : Form
    {
        private static Form3 form3 = null;
        public Form3()
        {
            InitializeComponent();
        }
        public static Form3 GetSingleForm3()
        {
            if (form3 == null || form3.IsDisposed == true)
            {
                form3 = new Form3();
            }
            return form3;
        }
    }
}
