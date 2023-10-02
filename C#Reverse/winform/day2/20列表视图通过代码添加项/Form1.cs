using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20列表视图通过代码添加项
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //添加项
            ListViewItem listViewItem1 = new ListViewItem("姐姐一号");
            listViewItem1.ImageIndex = 0;
            listViewItem1.SubItems.Add("中等");
            listViewItem1.SubItems.Add("超强");
            listViewItem1.SubItems.Add("弱");
            listViewItem1.SubItems.Add("难");
            this.listView1.Items.Add(listViewItem1);
            ListViewItem listViewItem2 = new ListViewItem("姐姐二号");
            listViewItem2.ImageIndex = 1;
            listViewItem2.SubItems.Add("中等");
            listViewItem2.SubItems.Add("弱");
            listViewItem2.SubItems.Add("弱");
            listViewItem2.SubItems.Add("难");
            this.listView1.Items.Add(listViewItem2);
            ListViewItem listViewItem3 = new ListViewItem("姐姐三号");
            listViewItem3.ImageIndex = 2;
            listViewItem3.SubItems.Add("超强");
            listViewItem3.SubItems.Add("超弱");
            listViewItem3.SubItems.Add("强");
            listViewItem3.SubItems.Add("超难");
            this.listView1.Items.Add(listViewItem3);
            ListViewItem listViewItem4 = new ListViewItem("姐姐四号");
            listViewItem4.ImageIndex = 3;
            listViewItem4.SubItems.Add("超弱");
            listViewItem4.SubItems.Add("超强");
            listViewItem4.SubItems.Add("中等");
            listViewItem4.SubItems.Add("中等");
            this.listView1.Items.Add(listViewItem4);
            ListViewItem listViewItem5 = new ListViewItem("姐姐五号");
            listViewItem5.Name = "5";
            listViewItem5.ImageIndex = 4;
            listViewItem5.SubItems.Add("超弱");
            listViewItem5.SubItems.Add("强");
            listViewItem5.SubItems.Add("中等");
            listViewItem5.SubItems.Add("较难");
            this.listView1.Items.Add(listViewItem5);
            this.listView1.View = View.Details;

            //1.通过对象名删除
            //this.listView1.Items.Remove(listViewItem5);
            //2.通过索引下标
            //this.listView1.Items.RemoveAt(4);
            //3.通过键值对方式
            //this.listView1.Items.RemoveByKey("5");

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //selectitems返回选中行的集合（因为可以多选），【0】表示我们选中的所有行里面的第一行
            ListViewItem listViewItem = this.listView1.SelectedItems[0];
            if (listViewItem == null)
            {
                return;
            }
            else
            {
                string str = "";
                str += "名字" + listViewItem.Text + "\r\n";
                //注意subitem里面的下标从1开始
                str += "生存能力：" + listViewItem.SubItems[1].Text + "\r\n";
                str += "攻击伤害：" + listViewItem.SubItems[2].Text + "\r\n";
                str += "技能效果：" + listViewItem.SubItems[3].Text + "\r\n";
                str += "上手难度：" + listViewItem.SubItems[4].Text + "\r\n";
                MessageBox.Show(str);
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem;
            try
            {
                listViewItem = this.listView1.SelectedItems[0];
                this.listView1.Items.Remove(listViewItem);
            }
            catch
            {
                MessageBox.Show("您未选择任何项，请重写选择。");
            }

        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void 详细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.List;
        }

        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Tile;
        }
    }
}
