using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03单例模式
{
    public partial class Form2 : Form
    {
        //初始为null，用于判断
        public static Form2 FrmSingle = null;
        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 GetForm2()
        {
            //实现单例
            if (FrmSingle == null)
            {
                FrmSingle = new Form2();
            }
            //只要不为null，不管创建多少个，都只会有一个对象。
            return FrmSingle;
        }
    }
}
