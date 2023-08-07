using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 程序加载时获得1949-今的年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //获得当前的年份
            int year = DateTime.Now.Year;
            //倒叙循环
            for (int i = year; i >= 1949; i--)
            {
                cboYear.Items.Add(i + "年");
            }

        }
        /// <summary>
        /// 当年分发生改变时，加载月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //每选一次年份，清空一次月份，不然会内容会累积
            cboMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i + "月");
            }

        }

        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 当月份发生改变时，加载天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDay.Items.Clear();
            int day = 0;
            //获得月
            string month = cboMonth.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int months = Convert.ToInt32(month);
            //获得月
            string year = cboYear.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int years = Convert.ToInt32(year);
            //判断月份
            switch (months)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    if ((years % 400 == 0) || (years % 4 == 0 && years % 100 != 0))
                        day = 29;
                    else
                        day = 28;
                    break;
                default:
                    day = 30;
                    break;
            }
            for (int i = 1; i <= day; i++)
            {
                cboDay.Items.Add(i + "日");
            }
        }
    }
}
