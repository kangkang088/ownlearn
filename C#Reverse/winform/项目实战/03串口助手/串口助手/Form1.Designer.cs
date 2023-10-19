namespace 串口助手 {
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
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.richTxtSend = new System.Windows.Forms.RichTextBox();
            this.richTxtReceive = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.DTRCheckBox = new System.Windows.Forms.CheckBox();
            this.RTSCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopBit_ComBox = new System.Windows.Forms.ComboBox();
            this.dataBit_ComBox = new System.Windows.Forms.ComboBox();
            this.checkBit_ComBox = new System.Windows.Forms.ComboBox();
            this.baud_ComBox = new System.Windows.Forms.ComboBox();
            this.port_ComBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReecive = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.hexReceiveCheckBox = new System.Windows.Forms.CheckBox();
            this.autoClearCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimeOfSend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.hexSendCheckBox = new System.Windows.Forms.CheckBox();
            this.autoSendCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.state_ToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendNum_ToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.receiveNum_ToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearNum_ToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(94, 23);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "手动发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // richTxtSend
            // 
            this.richTxtSend.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.richTxtSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtSend.Location = new System.Drawing.Point(3, 17);
            this.richTxtSend.Name = "richTxtSend";
            this.richTxtSend.Size = new System.Drawing.Size(457, 436);
            this.richTxtSend.TabIndex = 6;
            this.richTxtSend.Text = "";
            // 
            // richTxtReceive
            // 
            this.richTxtReceive.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.richTxtReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtReceive.Location = new System.Drawing.Point(3, 17);
            this.richTxtReceive.Name = "richTxtReceive";
            this.richTxtReceive.Size = new System.Drawing.Size(454, 225);
            this.richTxtReceive.TabIndex = 7;
            this.richTxtReceive.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.DTRCheckBox);
            this.groupBox1.Controls.Add(this.RTSCheckBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stopBit_ComBox);
            this.groupBox1.Controls.Add(this.dataBit_ComBox);
            this.groupBox1.Controls.Add(this.checkBit_ComBox);
            this.groupBox1.Controls.Add(this.baud_ComBox);
            this.groupBox1.Controls.Add(this.port_ComBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 292);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(73, 205);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(168, 38);
            this.btnOpenPort.TabIndex = 10;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // DTRCheckBox
            // 
            this.DTRCheckBox.AutoSize = true;
            this.DTRCheckBox.Location = new System.Drawing.Point(8, 227);
            this.DTRCheckBox.Name = "DTRCheckBox";
            this.DTRCheckBox.Size = new System.Drawing.Size(42, 16);
            this.DTRCheckBox.TabIndex = 9;
            this.DTRCheckBox.Text = "DTR";
            this.DTRCheckBox.UseVisualStyleBackColor = true;
            // 
            // RTSCheckBox
            // 
            this.RTSCheckBox.AutoSize = true;
            this.RTSCheckBox.Location = new System.Drawing.Point(8, 205);
            this.RTSCheckBox.Name = "RTSCheckBox";
            this.RTSCheckBox.Size = new System.Drawing.Size(42, 16);
            this.RTSCheckBox.TabIndex = 9;
            this.RTSCheckBox.Text = "RTS";
            this.RTSCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "端口号";
            // 
            // stopBit_ComBox
            // 
            this.stopBit_ComBox.FormattingEnabled = true;
            this.stopBit_ComBox.Location = new System.Drawing.Point(73, 124);
            this.stopBit_ComBox.Name = "stopBit_ComBox";
            this.stopBit_ComBox.Size = new System.Drawing.Size(168, 20);
            this.stopBit_ComBox.TabIndex = 0;
            // 
            // dataBit_ComBox
            // 
            this.dataBit_ComBox.FormattingEnabled = true;
            this.dataBit_ComBox.Location = new System.Drawing.Point(73, 98);
            this.dataBit_ComBox.Name = "dataBit_ComBox";
            this.dataBit_ComBox.Size = new System.Drawing.Size(168, 20);
            this.dataBit_ComBox.TabIndex = 0;
            // 
            // checkBit_ComBox
            // 
            this.checkBit_ComBox.FormattingEnabled = true;
            this.checkBit_ComBox.Location = new System.Drawing.Point(73, 72);
            this.checkBit_ComBox.Name = "checkBit_ComBox";
            this.checkBit_ComBox.Size = new System.Drawing.Size(168, 20);
            this.checkBit_ComBox.TabIndex = 0;
            // 
            // baud_ComBox
            // 
            this.baud_ComBox.FormattingEnabled = true;
            this.baud_ComBox.Location = new System.Drawing.Point(73, 46);
            this.baud_ComBox.Name = "baud_ComBox";
            this.baud_ComBox.Size = new System.Drawing.Size(168, 20);
            this.baud_ComBox.TabIndex = 0;
            // 
            // port_ComBox
            // 
            this.port_ComBox.FormattingEnabled = true;
            this.port_ComBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.port_ComBox.Location = new System.Drawing.Point(73, 20);
            this.port_ComBox.Name = "port_ComBox";
            this.port_ComBox.Size = new System.Drawing.Size(168, 20);
            this.port_ComBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReecive);
            this.groupBox2.Controls.Add(this.btnSelectPath);
            this.groupBox2.Controls.Add(this.btnSaveData);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.hexReceiveCheckBox);
            this.groupBox2.Controls.Add(this.autoClearCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 210);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // txtReecive
            // 
            this.txtReecive.Location = new System.Drawing.Point(6, 110);
            this.txtReecive.Name = "txtReecive";
            this.txtReecive.Size = new System.Drawing.Size(233, 21);
            this.txtReecive.TabIndex = 12;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(8, 80);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(74, 24);
            this.btnSelectPath.TabIndex = 11;
            this.btnSelectPath.Text = "选择路径";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(94, 80);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(74, 24);
            this.btnSaveData.TabIndex = 11;
            this.btnSaveData.Text = "保存数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(94, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 24);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "暂停";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(94, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 24);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "手动清空";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // hexReceiveCheckBox
            // 
            this.hexReceiveCheckBox.AutoSize = true;
            this.hexReceiveCheckBox.Location = new System.Drawing.Point(8, 50);
            this.hexReceiveCheckBox.Name = "hexReceiveCheckBox";
            this.hexReceiveCheckBox.Size = new System.Drawing.Size(72, 16);
            this.hexReceiveCheckBox.TabIndex = 9;
            this.hexReceiveCheckBox.Text = "十六进制";
            this.hexReceiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClearCheckBox
            // 
            this.autoClearCheckBox.AutoSize = true;
            this.autoClearCheckBox.Location = new System.Drawing.Point(8, 28);
            this.autoClearCheckBox.Name = "autoClearCheckBox";
            this.autoClearCheckBox.Size = new System.Drawing.Size(72, 16);
            this.autoClearCheckBox.TabIndex = 9;
            this.autoClearCheckBox.Text = "自动清空";
            this.autoClearCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimeOfSend);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSend);
            this.groupBox3.Controls.Add(this.btnOpenFile);
            this.groupBox3.Controls.Add(this.btnSendFile);
            this.groupBox3.Controls.Add(this.btnClearSend);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.hexSendCheckBox);
            this.groupBox3.Controls.Add(this.autoSendCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 512);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 207);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // txtTimeOfSend
            // 
            this.txtTimeOfSend.Location = new System.Drawing.Point(113, 162);
            this.txtTimeOfSend.Name = "txtTimeOfSend";
            this.txtTimeOfSend.Size = new System.Drawing.Size(126, 21);
            this.txtTimeOfSend.TabIndex = 14;
            this.txtTimeOfSend.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "自动发送周期(ms)";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(6, 126);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(233, 21);
            this.txtSend.TabIndex = 12;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(7, 81);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "打开文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(94, 81);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 4;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            // 
            // btnClearSend
            // 
            this.btnClearSend.Location = new System.Drawing.Point(94, 52);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(75, 23);
            this.btnClearSend.TabIndex = 4;
            this.btnClearSend.Text = "清空发送";
            this.btnClearSend.UseVisualStyleBackColor = true;
            // 
            // hexSendCheckBox
            // 
            this.hexSendCheckBox.AutoSize = true;
            this.hexSendCheckBox.Location = new System.Drawing.Point(7, 52);
            this.hexSendCheckBox.Name = "hexSendCheckBox";
            this.hexSendCheckBox.Size = new System.Drawing.Size(72, 16);
            this.hexSendCheckBox.TabIndex = 9;
            this.hexSendCheckBox.Text = "十六进制";
            this.hexSendCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoSendCheckBox
            // 
            this.autoSendCheckBox.AutoSize = true;
            this.autoSendCheckBox.Location = new System.Drawing.Point(8, 21);
            this.autoSendCheckBox.Name = "autoSendCheckBox";
            this.autoSendCheckBox.Size = new System.Drawing.Size(72, 16);
            this.autoSendCheckBox.TabIndex = 9;
            this.autoSendCheckBox.Text = "自动发送";
            this.autoSendCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTxtSend);
            this.groupBox4.Location = new System.Drawing.Point(265, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 456);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTxtReceive);
            this.groupBox5.Location = new System.Drawing.Point(268, 474);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(460, 245);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.state_ToolStripStatus,
            this.toolStripStatusLabel3,
            this.sendNum_ToolStripStatus,
            this.toolStripStatusLabel5,
            this.receiveNum_ToolStripStatus,
            this.clearNum_ToolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 722);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "状态";
            // 
            // state_ToolStripStatus
            // 
            this.state_ToolStripStatus.AutoSize = false;
            this.state_ToolStripStatus.Name = "state_ToolStripStatus";
            this.state_ToolStripStatus.Size = new System.Drawing.Size(200, 17);
            this.state_ToolStripStatus.Text = "初始化正常！";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "发送计数：";
            // 
            // sendNum_ToolStripStatus
            // 
            this.sendNum_ToolStripStatus.AutoSize = false;
            this.sendNum_ToolStripStatus.Name = "sendNum_ToolStripStatus";
            this.sendNum_ToolStripStatus.Size = new System.Drawing.Size(50, 17);
            this.sendNum_ToolStripStatus.Text = "0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel5.Text = "接收计数";
            // 
            // receiveNum_ToolStripStatus
            // 
            this.receiveNum_ToolStripStatus.AutoSize = false;
            this.receiveNum_ToolStripStatus.Name = "receiveNum_ToolStripStatus";
            this.receiveNum_ToolStripStatus.Size = new System.Drawing.Size(50, 17);
            this.receiveNum_ToolStripStatus.Text = "0";
            // 
            // clearNum_ToolStripStatus
            // 
            this.clearNum_ToolStripStatus.Name = "clearNum_ToolStripStatus";
            this.clearNum_ToolStripStatus.Size = new System.Drawing.Size(56, 17);
            this.clearNum_ToolStripStatus.Text = "清空计数";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 744);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox richTxtSend;
        private System.Windows.Forms.RichTextBox richTxtReceive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox stopBit_ComBox;
        private System.Windows.Forms.ComboBox dataBit_ComBox;
        private System.Windows.Forms.ComboBox checkBit_ComBox;
        private System.Windows.Forms.ComboBox baud_ComBox;
        private System.Windows.Forms.ComboBox port_ComBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.CheckBox DTRCheckBox;
        private System.Windows.Forms.CheckBox RTSCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReecive;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox hexReceiveCheckBox;
        private System.Windows.Forms.CheckBox autoClearCheckBox;
        private System.Windows.Forms.TextBox txtTimeOfSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.CheckBox hexSendCheckBox;
        private System.Windows.Forms.CheckBox autoSendCheckBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel state_ToolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sendNum_ToolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel receiveNum_ToolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel clearNum_ToolStripStatus;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

