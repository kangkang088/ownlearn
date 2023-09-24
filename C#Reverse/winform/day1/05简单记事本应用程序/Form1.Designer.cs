namespace _05简单记事本应用程序
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
            btnWorldWrap = new Button();
            btnSave = new Button();
            textBoxMain = new TextBox();
            labelUserName = new Label();
            labelPassword = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnWorldWrap
            // 
            btnWorldWrap.Location = new Point(115, 61);
            btnWorldWrap.Name = "btnWorldWrap";
            btnWorldWrap.Size = new Size(75, 23);
            btnWorldWrap.TabIndex = 0;
            btnWorldWrap.Text = "自动换行";
            btnWorldWrap.UseVisualStyleBackColor = true;
            btnWorldWrap.Click += btnWorldWrap_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(560, 61);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxMain
            // 
            textBoxMain.Location = new Point(115, 137);
            textBoxMain.Multiline = true;
            textBoxMain.Name = "textBoxMain";
            textBoxMain.Size = new Size(520, 267);
            textBoxMain.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(208, 206);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(56, 17);
            labelUserName.TabIndex = 3;
            labelUserName.Text = "用户名：";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(209, 238);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(44, 17);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "密码：";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(278, 203);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(168, 23);
            textBoxUserName.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(278, 232);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(168, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(278, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(textBoxMain);
            Controls.Add(btnSave);
            Controls.Add(btnWorldWrap);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWorldWrap;
        private Button btnSave;
        private TextBox textBoxMain;
        private Label labelUserName;
        private Label labelPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button btnLogin;
    }
}