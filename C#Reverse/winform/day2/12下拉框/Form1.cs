using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12下拉框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Text = "--请选择--";
            this.comboBox1.Items.Add("数码产品");
            this.comboBox1.Items.Add("家居产品");
            this.comboBox1.Items.Add("母婴幼儿");
            this.comboBox1.Items.Add("衣服鞋帽");
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            this.label2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str = "";
            //if (this.checkBox1.Checked)
            //{
            //    if (!str.Equals(""))
            //    {
            //        str += ",";
            //    }
            //    str += this.checkBox1.Text;

            //}
            //if (this.checkBox2.Checked)
            //{
            //    if (!str.Equals(""))
            //    {
            //        str += ",";
            //    }
            //    str += this.checkBox1.Text;

            //}
            //if (this.checkBox3.Checked)
            //{
            //    if (!str.Equals(""))
            //    {
            //        str += ",";
            //    }
            //    str += this.checkBox1.Text;

            //}
            //if (this.checkBox4.Checked)
            //{
            //    if (!str.Equals(""))
            //    {
            //        str += ",";
            //    }
            //    str += this.checkBox1.Text;

            //}
            //MessageBox.Show(str);

            string str = "";
            foreach (CheckBox item in this.panel1.Controls)
            {
                if (item.Checked)
                {
                    if (!str.Equals(""))
                    {
                        str += ",";
                    }
                    str += item.Text;
                }
            }
            MessageBox.Show(str);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
