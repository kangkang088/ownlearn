namespace _14图片集控件
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpeg");
            this.imageList1.Images.SetKeyName(1, "2.jpeg");
            this.imageList1.Images.SetKeyName(2, "3.jpeg");
            this.imageList1.Images.SetKeyName(3, "4.jpeg");
            this.imageList1.Images.SetKeyName(4, "5.jpeg");
            this.imageList1.Images.SetKeyName(5, "5e707f22eaf56defd74af1872a799221.jpeg");
            this.imageList1.Images.SetKeyName(6, "6.jpeg");
            this.imageList1.Images.SetKeyName(7, "7.jpeg");
            this.imageList1.Images.SetKeyName(8, "8.jpeg");
            this.imageList1.Images.SetKeyName(9, "9.jpeg");
            this.imageList1.Images.SetKeyName(10, "10.jpeg");
            this.imageList1.Images.SetKeyName(11, "11.jpeg");
            this.imageList1.Images.SetKeyName(12, "12.jpg");
            this.imageList1.Images.SetKeyName(13, "13.jpeg");
            this.imageList1.Images.SetKeyName(14, "14.jpeg");
            this.imageList1.Images.SetKeyName(15, "90ff20365f5e4a34d0a9f594507544a5.jpeg");
            this.imageList1.Images.SetKeyName(16, "3549b8853fd14876953273936502d2e6.jpeg");
            this.imageList1.Images.SetKeyName(17, "ab526b1d149d3f28656d79602be60739.jpeg");
            this.imageList1.Images.SetKeyName(18, "b9ce2e2d2d4f2615932f084a138947a1.jpeg");
            this.imageList1.Images.SetKeyName(19, "c8aa5b2127cfaa3e66683ba8812b774d.jpeg");
            this.imageList1.Images.SetKeyName(20, "d9e0cd14807fa95c6f4069aa0581b035.jpeg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(413, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "上一张";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "下一张";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 802);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

