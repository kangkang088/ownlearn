namespace _09Modbus项目1 {
    partial class Form1 {
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblshidu = new System.Windows.Forms.Label();
            this.lblwendu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnconnect = new System.Windows.Forms.Button();
            this.btnwrite = new System.Windows.Forms.Button();
            this.portcmb = new System.Windows.Forms.ComboBox();
            this.baudcmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stationAddresscmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "温度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "湿度：";
            // 
            // lblshidu
            // 
            this.lblshidu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblshidu.Location = new System.Drawing.Point(230, 153);
            this.lblshidu.Name = "lblshidu";
            this.lblshidu.Size = new System.Drawing.Size(84, 26);
            this.lblshidu.TabIndex = 4;
            this.lblshidu.Text = "0.0";
            this.lblshidu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwendu
            // 
            this.lblwendu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblwendu.Location = new System.Drawing.Point(496, 153);
            this.lblwendu.Name = "lblwendu";
            this.lblwendu.Size = new System.Drawing.Size(84, 26);
            this.lblwendu.TabIndex = 6;
            this.lblwendu.Text = "0.0";
            this.lblwendu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "%";
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(654, 59);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(75, 23);
            this.btnconnect.TabIndex = 11;
            this.btnconnect.Text = "建立连接";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(654, 160);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 23);
            this.btnwrite.TabIndex = 12;
            this.btnwrite.Text = "读取温湿度";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // portcmb
            // 
            this.portcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portcmb.FormattingEnabled = true;
            this.portcmb.Location = new System.Drawing.Point(230, 59);
            this.portcmb.Name = "portcmb";
            this.portcmb.Size = new System.Drawing.Size(121, 20);
            this.portcmb.TabIndex = 13;
            // 
            // baudcmb
            // 
            this.baudcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudcmb.FormattingEnabled = true;
            this.baudcmb.Location = new System.Drawing.Point(496, 59);
            this.baudcmb.Name = "baudcmb";
            this.baudcmb.Size = new System.Drawing.Size(121, 20);
            this.baudcmb.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "站地址：";
            // 
            // stationAddresscmb
            // 
            this.stationAddresscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stationAddresscmb.FormattingEnabled = true;
            this.stationAddresscmb.Location = new System.Drawing.Point(230, 106);
            this.stationAddresscmb.Name = "stationAddresscmb";
            this.stationAddresscmb.Size = new System.Drawing.Size(121, 20);
            this.stationAddresscmb.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 580);
            this.Controls.Add(this.baudcmb);
            this.Controls.Add(this.stationAddresscmb);
            this.Controls.Add(this.portcmb);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblwendu);
            this.Controls.Add(this.lblshidu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblshidu;
        private System.Windows.Forms.Label lblwendu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.ComboBox portcmb;
        private System.Windows.Forms.ComboBox baudcmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox stationAddresscmb;
    }
}

