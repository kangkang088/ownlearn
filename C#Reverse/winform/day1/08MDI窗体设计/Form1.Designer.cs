namespace _08MDI窗体设计
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            显示子窗体ToolStripMenuItem = new ToolStripMenuItem();
            横向排列ToolStripMenuItem = new ToolStripMenuItem();
            纵向排列ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 显示子窗体ToolStripMenuItem, 横向排列ToolStripMenuItem, 纵向排列ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 显示子窗体ToolStripMenuItem
            // 
            显示子窗体ToolStripMenuItem.Name = "显示子窗体ToolStripMenuItem";
            显示子窗体ToolStripMenuItem.Size = new Size(80, 21);
            显示子窗体ToolStripMenuItem.Text = "显示子窗体";
            显示子窗体ToolStripMenuItem.Click += 显示子窗体ToolStripMenuItem_Click;
            // 
            // 横向排列ToolStripMenuItem
            // 
            横向排列ToolStripMenuItem.Name = "横向排列ToolStripMenuItem";
            横向排列ToolStripMenuItem.Size = new Size(68, 21);
            横向排列ToolStripMenuItem.Text = "横向排列";
            横向排列ToolStripMenuItem.Click += 横向排列ToolStripMenuItem_Click;
            // 
            // 纵向排列ToolStripMenuItem
            // 
            纵向排列ToolStripMenuItem.Name = "纵向排列ToolStripMenuItem";
            纵向排列ToolStripMenuItem.Size = new Size(68, 21);
            纵向排列ToolStripMenuItem.Text = "纵向排列";
            纵向排列ToolStripMenuItem.Click += 纵向排列ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 显示子窗体ToolStripMenuItem;
        private ToolStripMenuItem 横向排列ToolStripMenuItem;
        private ToolStripMenuItem 纵向排列ToolStripMenuItem;
    }
}