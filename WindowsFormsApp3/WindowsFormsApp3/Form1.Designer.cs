namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.textBoxWzk = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonWzk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxWzk
            // 
            this.textBoxWzk.Location = new System.Drawing.Point(303, 49);
            this.textBoxWzk.Name = "textBoxWzk";
            this.textBoxWzk.Size = new System.Drawing.Size(100, 21);
            this.textBoxWzk.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonWzk
            // 
            this.buttonWzk.Location = new System.Drawing.Point(303, 76);
            this.buttonWzk.Name = "buttonWzk";
            this.buttonWzk.Size = new System.Drawing.Size(100, 30);
            this.buttonWzk.TabIndex = 2;
            this.buttonWzk.Text = "Clikc me!";
            this.buttonWzk.UseVisualStyleBackColor = true;
            this.buttonWzk.Click += new System.EventHandler(this.buttonWzk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWzk);
            this.Controls.Add(this.textBoxWzk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWzk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonWzk;
    }
}

