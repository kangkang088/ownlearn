namespace _10监控预警系统 {
    partial class FrmMain {
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPump01Power = new _10监控预警系统.UControls.ParaTextBox();
            this.txtPump01Fre = new _10监控预警系统.UControls.ParaTextBox();
            this.txtPump03Power = new _10监控预警系统.UControls.ParaTextBox();
            this.txtPump03Fre = new _10监控预警系统.UControls.ParaTextBox();
            this.txtPump02Power = new _10监控预警系统.UControls.ParaTextBox();
            this.txtPump02Fre = new _10监控预警系统.UControls.ParaTextBox();
            this.lightPump03Power = new _10监控预警系统.UControls.UCAlarmControl();
            this.lightPump03Fre = new _10监控预警系统.UControls.UCAlarmControl();
            this.uPump3 = new _10监控预警系统.UControls.UPump();
            this.lightPump02Power = new _10监控预警系统.UControls.UCAlarmControl();
            this.lightPump02Fre = new _10监控预警系统.UControls.UCAlarmControl();
            this.uPump2 = new _10监控预警系统.UControls.UPump();
            this.lightPump01Power = new _10监控预警系统.UControls.UCAlarmControl();
            this.lightPump01Fre = new _10监控预警系统.UControls.UCAlarmControl();
            this.uPump1 = new _10监控预警系统.UControls.UPump();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.Blue;
            this.btnStart.Location = new System.Drawing.Point(115, 95);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 52);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarm.ForeColor = System.Drawing.Color.Red;
            this.btnAlarm.Location = new System.Drawing.Point(684, 97);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(75, 52);
            this.btnAlarm.TabIndex = 5;
            this.btnAlarm.Text = "预警列表";
            this.btnAlarm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(213, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "未启动";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(132, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "1#水泵";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(478, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "2#水泵";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(800, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "3#水泵";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(85, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "频率：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(85, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "功率：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(449, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "频率：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(449, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "功率：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(770, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "频率：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(770, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "功率：";
            // 
            // txtPump01Power
            // 
            this.txtPump01Power.BackColor = System.Drawing.Color.White;
            this.txtPump01Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump01Power.DataVal = "100";
            this.txtPump01Power.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPump01Power.Location = new System.Drawing.Point(136, 512);
            this.txtPump01Power.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPump01Power.Name = "txtPump01Power";
            this.txtPump01Power.Size = new System.Drawing.Size(93, 28);
            this.txtPump01Power.TabIndex = 26;
            this.txtPump01Power.Unit = "KW";
            this.txtPump01Power.VarName = "Pump01Power";
            // 
            // txtPump01Fre
            // 
            this.txtPump01Fre.BackColor = System.Drawing.Color.White;
            this.txtPump01Fre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump01Fre.DataVal = "150";
            this.txtPump01Fre.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPump01Fre.Location = new System.Drawing.Point(136, 478);
            this.txtPump01Fre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPump01Fre.Name = "txtPump01Fre";
            this.txtPump01Fre.Size = new System.Drawing.Size(93, 28);
            this.txtPump01Fre.TabIndex = 27;
            this.txtPump01Fre.Unit = "Hz";
            this.txtPump01Fre.VarName = "Pump01Fre";
            // 
            // txtPump03Power
            // 
            this.txtPump03Power.BackColor = System.Drawing.Color.White;
            this.txtPump03Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump03Power.DataVal = "100";
            this.txtPump03Power.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPump03Power.Location = new System.Drawing.Point(822, 514);
            this.txtPump03Power.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPump03Power.Name = "txtPump03Power";
            this.txtPump03Power.Size = new System.Drawing.Size(93, 28);
            this.txtPump03Power.TabIndex = 24;
            this.txtPump03Power.Unit = "KW";
            this.txtPump03Power.VarName = "Pump03Power";
            // 
            // txtPump03Fre
            // 
            this.txtPump03Fre.BackColor = System.Drawing.Color.White;
            this.txtPump03Fre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump03Fre.DataVal = "150";
            this.txtPump03Fre.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPump03Fre.Location = new System.Drawing.Point(822, 478);
            this.txtPump03Fre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPump03Fre.Name = "txtPump03Fre";
            this.txtPump03Fre.Size = new System.Drawing.Size(93, 28);
            this.txtPump03Fre.TabIndex = 25;
            this.txtPump03Fre.Unit = "Hz";
            this.txtPump03Fre.VarName = "Pump03Fre";
            // 
            // txtPump02Power
            // 
            this.txtPump02Power.BackColor = System.Drawing.Color.White;
            this.txtPump02Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump02Power.DataVal = "100";
            this.txtPump02Power.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPump02Power.Location = new System.Drawing.Point(500, 511);
            this.txtPump02Power.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPump02Power.Name = "txtPump02Power";
            this.txtPump02Power.Size = new System.Drawing.Size(93, 28);
            this.txtPump02Power.TabIndex = 22;
            this.txtPump02Power.Unit = "KW";
            this.txtPump02Power.VarName = "Pump02Power";
            // 
            // txtPump02Fre
            // 
            this.txtPump02Fre.BackColor = System.Drawing.Color.White;
            this.txtPump02Fre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPump02Fre.DataVal = "150";
            this.txtPump02Fre.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPump02Fre.Location = new System.Drawing.Point(500, 477);
            this.txtPump02Fre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPump02Fre.Name = "txtPump02Fre";
            this.txtPump02Fre.Size = new System.Drawing.Size(93, 28);
            this.txtPump02Fre.TabIndex = 23;
            this.txtPump02Fre.Unit = "Hz";
            this.txtPump02Fre.VarName = "Pump02Fre";
            // 
            // lightPump03Power
            // 
            this.lightPump03Power.AlarmLightColor = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.LightBlue};
            this.lightPump03Power.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightPump03Power.IsOn = false;
            this.lightPump03Power.Location = new System.Drawing.Point(923, 498);
            this.lightPump03Power.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightPump03Power.Name = "lightPump03Power";
            this.lightPump03Power.Size = new System.Drawing.Size(37, 44);
            this.lightPump03Power.TabIndex = 21;
            this.lightPump03Power.TwinkleInterval = 0;
            this.lightPump03Power.VarName = null;
            // 
            // lightPump03Fre
            // 
            this.lightPump03Fre.AlarmLightColor = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime};
            this.lightPump03Fre.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightPump03Fre.IsOn = false;
            this.lightPump03Fre.Location = new System.Drawing.Point(923, 462);
            this.lightPump03Fre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightPump03Fre.Name = "lightPump03Fre";
            this.lightPump03Fre.Size = new System.Drawing.Size(37, 44);
            this.lightPump03Fre.TabIndex = 20;
            this.lightPump03Fre.TwinkleInterval = 0;
            this.lightPump03Fre.VarName = null;
            // 
            // uPump3
            // 
            this.uPump3.ActualState = false;
            this.uPump3.BtnBgColor = System.Drawing.Color.Green;
            this.uPump3.BtnText = "OFF";
            this.uPump3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uPump3.LightImp = global::_10监控预警系统.Properties.Resources.light_off;
            this.uPump3.Location = new System.Drawing.Point(773, 317);
            this.uPump3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uPump3.Name = "uPump3";
            this.uPump3.PumpStateName = "Pump03State";
            this.uPump3.Size = new System.Drawing.Size(142, 153);
            this.uPump3.TabIndex = 19;
            // 
            // lightPump02Power
            // 
            this.lightPump02Power.AlarmLightColor = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.LightBlue};
            this.lightPump02Power.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightPump02Power.IsOn = false;
            this.lightPump02Power.Location = new System.Drawing.Point(601, 498);
            this.lightPump02Power.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightPump02Power.Name = "lightPump02Power";
            this.lightPump02Power.Size = new System.Drawing.Size(37, 44);
            this.lightPump02Power.TabIndex = 18;
            this.lightPump02Power.TwinkleInterval = 0;
            this.lightPump02Power.VarName = null;
            // 
            // lightPump02Fre
            // 
            this.lightPump02Fre.AlarmLightColor = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime};
            this.lightPump02Fre.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightPump02Fre.IsOn = false;
            this.lightPump02Fre.Location = new System.Drawing.Point(601, 462);
            this.lightPump02Fre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightPump02Fre.Name = "lightPump02Fre";
            this.lightPump02Fre.Size = new System.Drawing.Size(37, 44);
            this.lightPump02Fre.TabIndex = 17;
            this.lightPump02Fre.TwinkleInterval = 0;
            this.lightPump02Fre.VarName = null;
            // 
            // uPump2
            // 
            this.uPump2.ActualState = false;
            this.uPump2.BtnBgColor = System.Drawing.Color.Green;
            this.uPump2.BtnText = "OFF";
            this.uPump2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uPump2.LightImp = global::_10监控预警系统.Properties.Resources.light_off;
            this.uPump2.Location = new System.Drawing.Point(452, 317);
            this.uPump2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uPump2.Name = "uPump2";
            this.uPump2.PumpStateName = "Pump02State";
            this.uPump2.Size = new System.Drawing.Size(141, 153);
            this.uPump2.TabIndex = 16;
            // 
            // lightPump01Power
            // 
            this.lightPump01Power.AlarmLightColor = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.LightBlue};
            this.lightPump01Power.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightPump01Power.IsOn = false;
            this.lightPump01Power.Location = new System.Drawing.Point(237, 498);
            this.lightPump01Power.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightPump01Power.Name = "lightPump01Power";
            this.lightPump01Power.Size = new System.Drawing.Size(37, 44);
            this.lightPump01Power.TabIndex = 3;
            this.lightPump01Power.TwinkleInterval = 0;
            this.lightPump01Power.VarName = null;
            // 
            // lightPump01Fre
            // 
            this.lightPump01Fre.AlarmLightColor = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime};
            this.lightPump01Fre.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightPump01Fre.IsOn = false;
            this.lightPump01Fre.Location = new System.Drawing.Point(237, 462);
            this.lightPump01Fre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightPump01Fre.Name = "lightPump01Fre";
            this.lightPump01Fre.Size = new System.Drawing.Size(37, 44);
            this.lightPump01Fre.TabIndex = 2;
            this.lightPump01Fre.TwinkleInterval = 0;
            this.lightPump01Fre.VarName = null;
            // 
            // uPump1
            // 
            this.uPump1.ActualState = false;
            this.uPump1.BtnBgColor = System.Drawing.Color.Green;
            this.uPump1.BtnText = "OFF";
            this.uPump1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uPump1.LightImp = global::_10监控预警系统.Properties.Resources.light_off;
            this.uPump1.Location = new System.Drawing.Point(88, 311);
            this.uPump1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uPump1.Name = "uPump1";
            this.uPump1.PumpStateName = "Pump01State";
            this.uPump1.Size = new System.Drawing.Size(141, 153);
            this.uPump1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 754);
            this.Controls.Add(this.txtPump01Power);
            this.Controls.Add(this.txtPump01Fre);
            this.Controls.Add(this.txtPump03Power);
            this.Controls.Add(this.txtPump03Fre);
            this.Controls.Add(this.txtPump02Power);
            this.Controls.Add(this.txtPump02Fre);
            this.Controls.Add(this.lightPump03Power);
            this.Controls.Add(this.lightPump03Fre);
            this.Controls.Add(this.uPump3);
            this.Controls.Add(this.lightPump02Power);
            this.Controls.Add(this.lightPump02Fre);
            this.Controls.Add(this.uPump2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lightPump01Power);
            this.Controls.Add(this.lightPump01Fre);
            this.Controls.Add(this.uPump1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "预警管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UControls.UPump uPump1;
        private UControls.UCAlarmControl lightPump01Fre;
        private UControls.UCAlarmControl lightPump01Power;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private UControls.UCAlarmControl lightPump02Power;
        private UControls.UCAlarmControl lightPump02Fre;
        private UControls.UPump uPump2;
        private UControls.UCAlarmControl lightPump03Power;
        private UControls.UCAlarmControl lightPump03Fre;
        private UControls.UPump uPump3;
        private UControls.ParaTextBox txtPump02Power;
        private UControls.ParaTextBox txtPump02Fre;
        private UControls.ParaTextBox txtPump03Power;
        private UControls.ParaTextBox txtPump03Fre;
        private UControls.ParaTextBox txtPump01Power;
        private UControls.ParaTextBox txtPump01Fre;
    }
}

