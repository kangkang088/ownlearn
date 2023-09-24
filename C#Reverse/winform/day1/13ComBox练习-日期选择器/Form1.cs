using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13ComBox练习_日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i >= 1949; i--)
            {
                this.comboBoxYear.Items.Add(i.ToString() + "年");
            }
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDay.Items.Clear();
            int day = 0;
            string strMonth = comboBoxMonth.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string strYear = comboBoxYear.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int year = Convert.ToInt32(strYear);
            int month = Convert.ToInt32(strMonth);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: day = 31; break;
                case 2:
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        day = 29;
                    }
                    else { day = 28; }
                    break;
                default: day = 30; break;
            }
            for (int i = 0; i <= day; i++)
            { 
                this.comboBoxDay.Items.Add(i.ToString() + '日');
            }
        }

        private void comboBoxYera_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMonth.Items.Clear();
            for (int i = 1; i <= 12; i++) { comboBoxMonth.Items.Add(i.ToString() + "月"); }
        }
    }
}
