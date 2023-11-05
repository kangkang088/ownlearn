namespace _10监控预警系统.UControls {
    partial class UPump {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLight = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Controls.Add(this.picLight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 39);
            this.panel1.TabIndex = 0;
            // 
            // picLight
            // 
            this.picLight.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLight.Image = global::_10监控预警系统.Properties.Resources.light_on;
            this.picLight.Location = new System.Drawing.Point(0, 0);
            this.picLight.Name = "picLight";
            this.picLight.Size = new System.Drawing.Size(44, 39);
            this.picLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLight.TabIndex = 1;
            this.picLight.TabStop = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitch.BackColor = System.Drawing.Color.Orange;
            this.btnSwitch.FlatAppearance.BorderSize = 0;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Location = new System.Drawing.Point(50, 3);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(89, 33);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "ON";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::_10监控预警系统.Properties.Resources.jdb;
            this.pictureBox2.Location = new System.Drawing.Point(0, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // UPump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "UPump";
            this.Size = new System.Drawing.Size(142, 129);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLight;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
