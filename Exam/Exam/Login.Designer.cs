namespace Exam_System
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_UserName = new TextBox();
            lab_UserName = new Label();
            txt_Password = new TextBox();
            label4 = new Label();
            btn_LogIn = new Button();
            com_Subject = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 365);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Ink Free", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(45, 146);
            label1.Name = "label1";
            label1.Size = new Size(111, 36);
            label1.TabIndex = 8;
            label1.Text = "System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Font = new Font("Ink Free", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(170, 36);
            label3.TabIndex = 7;
            label3.Text = "Examination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Ink Free", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(293, 21);
            label2.Name = "label2";
            label2.Size = new Size(106, 36);
            label2.TabIndex = 9;
            label2.Text = "Log In";
            // 
            // txt_UserName
            // 
            txt_UserName.BackColor = Color.White;
            txt_UserName.BorderStyle = BorderStyle.FixedSingle;
            txt_UserName.Location = new Point(216, 195);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(197, 23);
            txt_UserName.TabIndex = 15;
            // 
            // lab_UserName
            // 
            lab_UserName.AutoSize = true;
            lab_UserName.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_UserName.ForeColor = Color.FromArgb(255, 192, 192);
            lab_UserName.Location = new Point(216, 155);
            lab_UserName.Name = "lab_UserName";
            lab_UserName.Size = new Size(106, 21);
            lab_UserName.TabIndex = 14;
            lab_UserName.Text = "User Name :";
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.White;
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Location = new Point(216, 270);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(197, 23);
            txt_Password.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(216, 230);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 16;
            label4.Text = "Password :";
            // 
            // btn_LogIn
            // 
            btn_LogIn.BackColor = Color.FromArgb(255, 192, 192);
            btn_LogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LogIn.ForeColor = SystemColors.ActiveCaptionText;
            btn_LogIn.Location = new Point(248, 314);
            btn_LogIn.Name = "btn_LogIn";
            btn_LogIn.Size = new Size(115, 39);
            btn_LogIn.TabIndex = 18;
            btn_LogIn.Text = "Log In";
            btn_LogIn.UseVisualStyleBackColor = false;
            btn_LogIn.Click += btn_LogIn_Click;
            // 
            // com_Subject
            // 
            com_Subject.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            com_Subject.ForeColor = SystemColors.GrayText;
            com_Subject.FormattingEnabled = true;
            com_Subject.Location = new Point(216, 115);
            com_Subject.Name = "com_Subject";
            com_Subject.Size = new Size(197, 27);
            com_Subject.TabIndex = 19;
            com_Subject.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(216, 74);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 20;
            label5.Text = "Subject:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 365);
            Controls.Add(label5);
            Controls.Add(com_Subject);
            Controls.Add(btn_LogIn);
            Controls.Add(txt_Password);
            Controls.Add(label4);
            Controls.Add(txt_UserName);
            Controls.Add(lab_UserName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txt_UserName;
        private Label lab_UserName;
        private TextBox txt_Password;
        private Label label4;
        private Button btn_LogIn;
        private ComboBox com_Subject;
        private Label label5;
    }
}