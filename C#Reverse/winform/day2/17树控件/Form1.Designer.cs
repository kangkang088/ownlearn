namespace _17树控件
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C#程序设计");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SQL Server数据库");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("计算机科学于技术", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("搜索引擎优化");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("网络推广");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("电子商务", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("武汉****学院", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点2";
            treeNode1.Text = "C#程序设计";
            treeNode2.Name = "节点3";
            treeNode2.Text = "SQL Server数据库";
            treeNode3.Name = "节点1";
            treeNode3.Text = "计算机科学于技术";
            treeNode4.Name = "节点5";
            treeNode4.Text = "搜索引擎优化";
            treeNode5.Name = "节点6";
            treeNode5.Text = "网络推广";
            treeNode6.Name = "节点4";
            treeNode6.Text = "电子商务";
            treeNode7.Name = "节点0";
            treeNode7.Text = "武汉****学院";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(307, 657);
            this.treeView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 657);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

