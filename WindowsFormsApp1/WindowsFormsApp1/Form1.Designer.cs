namespace WindowsFormsApp1
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
            this.textBoxHelloWorld = new System.Windows.Forms.TextBox();
            this.ShowHelloWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHelloWorld
            // 
            this.textBoxHelloWorld.Location = new System.Drawing.Point(323, 23);
            this.textBoxHelloWorld.Name = "textBoxHelloWorld";
            this.textBoxHelloWorld.Size = new System.Drawing.Size(100, 21);
            this.textBoxHelloWorld.TabIndex = 0;
            this.textBoxHelloWorld.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowHelloWorld
            // 
            this.ShowHelloWorld.Location = new System.Drawing.Point(323, 50);
            this.ShowHelloWorld.Name = "ShowHelloWorld";
            this.ShowHelloWorld.Size = new System.Drawing.Size(100, 23);
            this.ShowHelloWorld.TabIndex = 1;
            this.ShowHelloWorld.Text = "click me\r\n";
            this.ShowHelloWorld.UseVisualStyleBackColor = true;
            this.ShowHelloWorld.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowHelloWorld);
            this.Controls.Add(this.textBoxHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHelloWorld;
        private System.Windows.Forms.Button ShowHelloWorld;
    }
}

