using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18树控件_通过代码添加或删除节点
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 方案一：使用TreeNode对象添加节点，删除节点，设置节点图标
            ////添加节点-----------------------------------------------------------------------------------------
            ////创建根节点
            //TreeNode root = new TreeNode("武汉****学院",0,0);
            //root.Name = "s1";
            //this.treeView1.Nodes.Add(root);
            ////创建子节点
            //TreeNode profession1 = new TreeNode("计算机技术",1,1);
            //profession1.Name = "p1";
            //TreeNode profession2 = new TreeNode("电子商务",1,1);
            //profession2.Name = "p2";
            //root.Nodes.Add(profession1);
            //root.Nodes.Add(profession2);
            ////创建子节点的子节点
            //TreeNode profession3 = new TreeNode("C#程序开发",2,2);
            //profession3.Name = "c1";
            //TreeNode profession4 = new TreeNode("SQL Server数据库",2,2);
            //profession4.Name = "c2";
            //TreeNode profession5 = new TreeNode("搜索引擎优化",2,2);
            //profession5.Name = "c3";
            //TreeNode profession6 = new TreeNode("网络营销",2,2);
            //profession6.Name = "c4";
            //profession1.Nodes.Add(profession3);
            //profession1.Nodes.Add(profession4);
            //profession2.Nodes.Add(profession5);
            //profession2.Nodes.Add(profession6);

            ////删除节点-----------------------------------------------------------------------------------------
            ////1.根据对象
            ////this.treeView1.Nodes.Remove(profession5);
            ////2.根据下标
            ////this.treeView1.Nodes[0].Nodes[1].Nodes.RemoveAt(0);
            ////3.通过键删除  如果是以键值对的方式添加的，就不需要再设置name了
            ////this.treeView1.Nodes["s1"].Nodes["p2"].Nodes.RemoveByKey("c3");

            ////设置节点图标--------------------------------------------------------------------------------------
            ////1.
            ////TreeNode root = new TreeNode("武汉****学院", 0, 0);
            ////2.
            ////root.ImageIndex = 0;
            ////root.SelectedImageIndex = 0;


            //this.treeView1.ExpandAll();
            #endregion

            #region 方案二：使用键值对集合方式直接添加节点，删除节点，设置节点图标
            this.treeView1.Nodes.Add("001", "武汉***学院",0,0);
            this.treeView1.Nodes["001"].Nodes.Add("001001", "计算机科学与技术",1,1);
            this.treeView1.Nodes["001"].Nodes.Add("001002", "电子商务",1,1);
            this.treeView1.Nodes["001"].Nodes["001001"].Nodes.Add("001001001", "C#语言设计",2,2);
            this.treeView1.Nodes["001"].Nodes["001001"].Nodes.Add("001001002", "SQL Server数据库",2,2);
            this.treeView1.Nodes["001"].Nodes["001002"].Nodes.Add("001002001", "搜索引擎优化",2,2);
            this.treeView1.Nodes["001"].Nodes["001002"].Nodes.Add("001002002", "网络营销",2,2);

            //设置节点图标-----------------------------------------------------------------------------
            //1.
            //this.treeView1.Nodes.Add("001", "武汉***学院", 0, 0);
            //2.
            //this.treeView1.Nodes["001"].ImageIndex = 0;
            //this.treeView1.Nodes["001"].SelectedImageIndex = 0;

            this.treeView1.ExpandAll();
            #endregion


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = this.treeView1.SelectedNode;
            //必须以键值对方式添加节点，否则可能没有name属性，输出空字符串
             MessageBox.Show(treeNode.Name + "," + treeNode.Text);
        }
    }
}
