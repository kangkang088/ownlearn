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
            this.richTxtReceive = new System.Windows.Forms.RichTextBox();
            this.richTxtSend = new System.Windows.Forms.RichTextBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.startDataZhen = new System.Windows.Forms.CheckBox();
            this.txtDataZhen = new System.Windows.Forms.TextBox();
            this.txtData4 = new System.Windows.Forms.TextBox();
            this.txtData3 = new System.Windows.Forms.TextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // richTxtReceive
            // 
            this.richTxtReceive.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.richTxtReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtReceive.Location = new System.Drawing.Point(3, 17);
            this.richTxtReceive.Name = "richTxtReceive";
            this.richTxtReceive.Size = new System.Drawing.Size(457, 436);
            this.richTxtReceive.TabIndex = 6;
            this.richTxtReceive.Text = "";
            // 
            // richTxtSend
            // 
            this.richTxtSend.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.richTxtSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtSend.Location = new System.Drawing.Point(3, 17);
            this.richTxtSend.Name = "richTxtSend";
            this.richTxtSend.Size = new System.Drawing.Size(454, 225);
            this.richTxtSend.TabIndex = 7;
            this.richTxtSend.Text = "";
            this.richTxtSend.TextChanged += new System.EventHandler(this.richTxtSend_TextChanged);
            this.richTxtSend.Leave += new System.EventHandler(this.richTxtSend_Leave);
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
            this.DTRCheckBox.CheckedChanged += new System.EventHandler(this.DTRCheckBox_CheckedChanged);
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
            this.RTSCheckBox.CheckedChanged += new System.EventHandler(this.RTSCheckBox_CheckedChanged);
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
            this.stopBit_ComBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBit_ComBox.Location = new System.Drawing.Point(73, 124);
            this.stopBit_ComBox.Name = "stopBit_ComBox";
            this.stopBit_ComBox.Size = new System.Drawing.Size(168, 20);
            this.stopBit_ComBox.TabIndex = 0;
            // 
            // dataBit_ComBox
            // 
            this.dataBit_ComBox.FormattingEnabled = true;
            this.dataBit_ComBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBit_ComBox.Location = new System.Drawing.Point(73, 98);
            this.dataBit_ComBox.Name = "dataBit_ComBox";
            this.dataBit_ComBox.Size = new System.Drawing.Size(168, 20);
            this.dataBit_ComBox.TabIndex = 0;
            // 
            // checkBit_ComBox
            // 
            this.checkBit_ComBox.FormattingEnabled = true;
            this.checkBit_ComBox.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN"});
            this.checkBit_ComBox.Location = new System.Drawing.Point(73, 72);
            this.checkBit_ComBox.Name = "checkBit_ComBox";
            this.checkBit_ComBox.Size = new System.Drawing.Size(168, 20);
            this.checkBit_ComBox.TabIndex = 0;
            // 
            // baud_ComBox
            // 
            this.baud_ComBox.FormattingEnabled = true;
            this.baud_ComBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.baud_ComBox.Location = new System.Drawing.Point(73, 46);
            this.baud_ComBox.Name = "baud_ComBox";
            this.baud_ComBox.Size = new System.Drawing.Size(168, 20);
            this.baud_ComBox.TabIndex = 0;
            // 
            // port_ComBox
            // 
            this.port_ComBox.FormattingEnabled = true;
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
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(94, 80);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(74, 24);
            this.btnSaveData.TabIndex = 11;
            this.btnSaveData.Text = "保存数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(94, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 24);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "暂停";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(94, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 24);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "手动清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.hexReceiveCheckBox.CheckedChanged += new System.EventHandler(this.hexReceiveCheckBox_CheckedChanged);
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
            this.autoClearCheckBox.CheckedChanged += new System.EventHandler(this.autoClearCheckBox_CheckedChanged);
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
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(94, 81);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 4;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnClearSend
            // 
            this.btnClearSend.Location = new System.Drawing.Point(94, 52);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(75, 23);
            this.btnClearSend.TabIndex = 4;
            this.btnClearSend.Text = "清空发送";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
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
            this.hexSendCheckBox.CheckedChanged += new System.EventHandler(this.hexSendCheckBox_CheckedChanged);
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
            this.autoSendCheckBox.CheckedChanged += new System.EventHandler(this.autoSendCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTxtReceive);
            this.groupBox4.Location = new System.Drawing.Point(265, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 456);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTxtSend);
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
            this.statusStrip1.Size = new System.Drawing.Size(922, 22);
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
            this.clearNum_ToolStripStatus.Click += new System.EventHandler(this.clearNum_ToolStripStatus_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.startDataZhen);
            this.groupBox6.Controls.Add(this.txtDataZhen);
            this.groupBox6.Controls.Add(this.txtData4);
            this.groupBox6.Controls.Add(this.txtData3);
            this.groupBox6.Controls.Add(this.txtData2);
            this.groupBox6.Controls.Add(this.txtData1);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(734, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(183, 456);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "指令解析";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(12, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 14);
            this.label14.TabIndex = 4;
            this.label14.Text = "例：7f0431323334DE10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(12, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 14);
            this.label13.TabIndex = 4;
            this.label13.Text = "7F+长度+数据+CRC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(6, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "格式：";
            // 
            // startDataZhen
            // 
            this.startDataZhen.AutoSize = true;
            this.startDataZhen.Location = new System.Drawing.Point(9, 250);
            this.startDataZhen.Name = "startDataZhen";
            this.startDataZhen.Size = new System.Drawing.Size(108, 16);
            this.startDataZhen.TabIndex = 3;
            this.startDataZhen.Text = "启动数据帧接收";
            this.startDataZhen.UseVisualStyleBackColor = true;
            // 
            // txtDataZhen
            // 
            this.txtDataZhen.Location = new System.Drawing.Point(9, 176);
            this.txtDataZhen.Multiline = true;
            this.txtDataZhen.Name = "txtDataZhen";
            this.txtDataZhen.Size = new System.Drawing.Size(145, 67);
            this.txtDataZhen.TabIndex = 2;
            // 
            // txtData4
            // 
            this.txtData4.Location = new System.Drawing.Point(54, 118);
            this.txtData4.Name = "txtData4";
            this.txtData4.Size = new System.Drawing.Size(100, 21);
            this.txtData4.TabIndex = 1;
            // 
            // txtData3
            // 
            this.txtData3.Location = new System.Drawing.Point(54, 91);
            this.txtData3.Name = "txtData3";
            this.txtData3.Size = new System.Drawing.Size(100, 21);
            this.txtData3.TabIndex = 1;
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(54, 64);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(100, 21);
            this.txtData2.TabIndex = 1;
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(54, 37);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(100, 21);
            this.txtData1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "数据帧";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 744);
            this.Controls.Add(this.groupBox6);
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox richTxtReceive;
        private System.Windows.Forms.RichTextBox richTxtSend;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtData4;
        private System.Windows.Forms.TextBox txtData3;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox startDataZhen;
        private System.Windows.Forms.TextBox txtDataZhen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer2;
    }
}

