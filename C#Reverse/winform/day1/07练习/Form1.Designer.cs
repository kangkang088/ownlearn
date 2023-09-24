namespace _07练习
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
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            rdoStudent = new RadioButton();
            rdoTeacher = new RadioButton();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 111);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "用户名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 151);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "密码";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(180, 105);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(198, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(180, 145);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(198, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // rdoStudent
            // 
            rdoStudent.AutoSize = true;
            rdoStudent.Location = new Point(144, 202);
            rdoStudent.Name = "rdoStudent";
            rdoStudent.Size = new Size(50, 21);
            rdoStudent.TabIndex = 4;
            rdoStudent.TabStop = true;
            rdoStudent.Text = "学生";
            rdoStudent.UseVisualStyleBackColor = true;
            // 
            // rdoTeacher
            // 
            rdoTeacher.AutoSize = true;
            rdoTeacher.Location = new Point(285, 202);
            rdoTeacher.Name = "rdoTeacher";
            rdoTeacher.Size = new Size(50, 21);
            rdoTeacher.TabIndex = 5;
            rdoTeacher.TabStop = true;
            rdoTeacher.Text = "老师";
            rdoTeacher.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(119, 252);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
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
            Controls.Add(rdoTeacher);
            Controls.Add(rdoStudent);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private RadioButton rdoStudent;
        private RadioButton rdoTeacher;
        private Button btnLogin;
    }
}