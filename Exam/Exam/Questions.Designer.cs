namespace Exam_System
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            panel1 = new Panel();
            panel2 = new Panel();
            lab_QuestionBank = new Label();
            dataGrid_QuestionBank = new DataGridView();
            btn_Reset = new Button();
            btn_Edit = new Button();
            btn_Save = new Button();
            com_Subject = new ComboBox();
            txt_option5 = new TextBox();
            txt_option4 = new TextBox();
            txt_option3 = new TextBox();
            txt_option2 = new TextBox();
            txt_option1 = new TextBox();
            lab_option5 = new Label();
            lab_option4 = new Label();
            lab_option3 = new Label();
            lab_option1 = new Label();
            lab_option2 = new Label();
            lab_quastion = new Label();
            txt_question = new TextBox();
            panel4 = new Panel();
            lab_Student = new Label();
            lab_Subject = new Label();
            lab_Question = new Label();
            lab_header = new Label();
            panel3 = new Panel();
            pic_Helping = new PictureBox();
            pic_programming = new PictureBox();
            pic_Exist = new PictureBox();
            pic_reporting = new PictureBox();
            pic_Educating = new PictureBox();
            pic_FillCircle = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_QuestionBank).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Helping).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_programming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Exist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_reporting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Educating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_FillCircle).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 611);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(lab_QuestionBank);
            panel2.Controls.Add(dataGrid_QuestionBank);
            panel2.Controls.Add(btn_Reset);
            panel2.Controls.Add(btn_Edit);
            panel2.Controls.Add(btn_Save);
            panel2.Controls.Add(com_Subject);
            panel2.Controls.Add(txt_option5);
            panel2.Controls.Add(txt_option4);
            panel2.Controls.Add(txt_option3);
            panel2.Controls.Add(txt_option2);
            panel2.Controls.Add(txt_option1);
            panel2.Controls.Add(lab_option5);
            panel2.Controls.Add(lab_option4);
            panel2.Controls.Add(lab_option3);
            panel2.Controls.Add(lab_option1);
            panel2.Controls.Add(lab_option2);
            panel2.Controls.Add(lab_quastion);
            panel2.Controls.Add(txt_question);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lab_Student);
            panel2.Controls.Add(lab_Subject);
            panel2.Controls.Add(lab_Question);
            panel2.Controls.Add(lab_header);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1194, 631);
            panel2.TabIndex = 0;
            // 
            // lab_QuestionBank
            // 
            lab_QuestionBank.AutoSize = true;
            lab_QuestionBank.Font = new Font("Arial Unicode MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_QuestionBank.Location = new Point(389, 294);
            lab_QuestionBank.Name = "lab_QuestionBank";
            lab_QuestionBank.Size = new Size(222, 36);
            lab_QuestionBank.TabIndex = 23;
            lab_QuestionBank.Text = "Questions Bank";
            // 
            // dataGrid_QuestionBank
            // 
            dataGrid_QuestionBank.BackgroundColor = Color.White;
            dataGrid_QuestionBank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_QuestionBank.Location = new Point(0, 370);
            dataGrid_QuestionBank.Name = "dataGrid_QuestionBank";
            dataGrid_QuestionBank.RowTemplate.Height = 25;
            dataGrid_QuestionBank.Size = new Size(1126, 241);
            dataGrid_QuestionBank.TabIndex = 22;
            dataGrid_QuestionBank.CellClick += dataGrid_QuestionBank_CellContentClick;
            dataGrid_QuestionBank.CellContentClick += dataGrid_QuestionBank_CellContentClick;
            // 
            // btn_Reset
            // 
            btn_Reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Reset.Location = new Point(604, 240);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(134, 36);
            btn_Reset.TabIndex = 21;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Edit.Location = new Point(411, 240);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(127, 36);
            btn_Edit.TabIndex = 20;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.Location = new Point(221, 240);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(122, 36);
            btn_Save.TabIndex = 19;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // com_Subject
            // 
            com_Subject.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            com_Subject.ForeColor = SystemColors.MenuHighlight;
            com_Subject.FormattingEnabled = true;
            com_Subject.Location = new Point(708, 66);
            com_Subject.Name = "com_Subject";
            com_Subject.Size = new Size(197, 27);
            com_Subject.TabIndex = 18;
            com_Subject.Text = "Subject";
            // 
            // txt_option5
            // 
            txt_option5.BackColor = Color.FromArgb(255, 192, 192);
            txt_option5.BorderStyle = BorderStyle.FixedSingle;
            txt_option5.Location = new Point(708, 197);
            txt_option5.Name = "txt_option5";
            txt_option5.Size = new Size(197, 23);
            txt_option5.TabIndex = 17;
            // 
            // txt_option4
            // 
            txt_option4.BackColor = Color.FromArgb(255, 192, 192);
            txt_option4.BorderStyle = BorderStyle.FixedSingle;
            txt_option4.Location = new Point(414, 197);
            txt_option4.Name = "txt_option4";
            txt_option4.Size = new Size(197, 23);
            txt_option4.TabIndex = 16;
            // 
            // txt_option3
            // 
            txt_option3.BackColor = Color.FromArgb(255, 192, 192);
            txt_option3.BorderStyle = BorderStyle.FixedSingle;
            txt_option3.Location = new Point(81, 197);
            txt_option3.Name = "txt_option3";
            txt_option3.Size = new Size(197, 23);
            txt_option3.TabIndex = 15;
            // 
            // txt_option2
            // 
            txt_option2.BackColor = Color.FromArgb(255, 192, 192);
            txt_option2.BorderStyle = BorderStyle.FixedSingle;
            txt_option2.Location = new Point(708, 142);
            txt_option2.Name = "txt_option2";
            txt_option2.Size = new Size(197, 23);
            txt_option2.TabIndex = 14;
            // 
            // txt_option1
            // 
            txt_option1.BackColor = Color.FromArgb(255, 192, 192);
            txt_option1.BorderStyle = BorderStyle.FixedSingle;
            txt_option1.Location = new Point(414, 142);
            txt_option1.Name = "txt_option1";
            txt_option1.Size = new Size(197, 23);
            txt_option1.TabIndex = 13;
            // 
            // lab_option5
            // 
            lab_option5.AutoSize = true;
            lab_option5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_option5.ForeColor = SystemColors.GrayText;
            lab_option5.Location = new Point(708, 168);
            lab_option5.Name = "lab_option5";
            lab_option5.Size = new Size(68, 21);
            lab_option5.TabIndex = 12;
            lab_option5.Text = "Answer";
            // 
            // lab_option4
            // 
            lab_option4.AutoSize = true;
            lab_option4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_option4.ForeColor = SystemColors.GrayText;
            lab_option4.Location = new Point(416, 168);
            lab_option4.Name = "lab_option4";
            lab_option4.Size = new Size(74, 21);
            lab_option4.TabIndex = 11;
            lab_option4.Text = "Option4";
            // 
            // lab_option3
            // 
            lab_option3.AutoSize = true;
            lab_option3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_option3.ForeColor = SystemColors.GrayText;
            lab_option3.Location = new Point(81, 168);
            lab_option3.Name = "lab_option3";
            lab_option3.Size = new Size(74, 21);
            lab_option3.TabIndex = 10;
            lab_option3.Text = "Option3";
            // 
            // lab_option1
            // 
            lab_option1.AutoSize = true;
            lab_option1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_option1.ForeColor = SystemColors.GrayText;
            lab_option1.Location = new Point(414, 116);
            lab_option1.Name = "lab_option1";
            lab_option1.Size = new Size(74, 21);
            lab_option1.TabIndex = 9;
            lab_option1.Text = "Option1";
            // 
            // lab_option2
            // 
            lab_option2.AutoSize = true;
            lab_option2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_option2.ForeColor = SystemColors.GrayText;
            lab_option2.Location = new Point(708, 116);
            lab_option2.Name = "lab_option2";
            lab_option2.Size = new Size(74, 21);
            lab_option2.TabIndex = 8;
            lab_option2.Text = "Option2";
            // 
            // lab_quastion
            // 
            lab_quastion.AutoSize = true;
            lab_quastion.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_quastion.ForeColor = SystemColors.GrayText;
            lab_quastion.Location = new Point(81, 116);
            lab_quastion.Name = "lab_quastion";
            lab_quastion.Size = new Size(86, 21);
            lab_quastion.TabIndex = 7;
            lab_quastion.Text = "Question ";
            // 
            // txt_question
            // 
            txt_question.BackColor = Color.FromArgb(255, 192, 192);
            txt_question.BorderStyle = BorderStyle.FixedSingle;
            txt_question.Location = new Point(81, 142);
            txt_question.Name = "txt_question";
            txt_question.Size = new Size(197, 23);
            txt_question.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(176, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(136, 3);
            panel4.TabIndex = 5;
            // 
            // lab_Student
            // 
            lab_Student.AutoSize = true;
            lab_Student.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Student.Location = new Point(485, 53);
            lab_Student.Name = "lab_Student";
            lab_Student.Size = new Size(78, 23);
            lab_Student.TabIndex = 4;
            lab_Student.Text = "Students";
            lab_Student.Click += lab_Student_Click;
            // 
            // lab_Subject
            // 
            lab_Subject.AutoSize = true;
            lab_Subject.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Subject.Location = new Point(351, 53);
            lab_Subject.Name = "lab_Subject";
            lab_Subject.Size = new Size(76, 23);
            lab_Subject.TabIndex = 3;
            lab_Subject.Text = "Subjects";
            lab_Subject.Click += lab_Subject_Click;
            // 
            // lab_Question
            // 
            lab_Question.AutoSize = true;
            lab_Question.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Question.Location = new Point(210, 53);
            lab_Question.Name = "lab_Question";
            lab_Question.Size = new Size(88, 23);
            lab_Question.TabIndex = 2;
            lab_Question.Text = "Questions";
            lab_Question.Click += lab_Question_Click;
            // 
            // lab_header
            // 
            lab_header.AutoSize = true;
            lab_header.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lab_header.ForeColor = SystemColors.ControlDarkDark;
            lab_header.Location = new Point(23, 18);
            lab_header.Name = "lab_header";
            lab_header.Size = new Size(125, 25);
            lab_header.TabIndex = 1;
            lab_header.Text = "Exam System";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(pic_Helping);
            panel3.Controls.Add(pic_programming);
            panel3.Controls.Add(pic_Exist);
            panel3.Controls.Add(pic_reporting);
            panel3.Controls.Add(pic_Educating);
            panel3.Controls.Add(pic_FillCircle);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1125, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(69, 631);
            panel3.TabIndex = 0;
            // 
            // pic_Helping
            // 
            pic_Helping.Image = (Image)resources.GetObject("pic_Helping.Image");
            pic_Helping.Location = new Point(12, 344);
            pic_Helping.Name = "pic_Helping";
            pic_Helping.Size = new Size(43, 30);
            pic_Helping.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Helping.TabIndex = 5;
            pic_Helping.TabStop = false;
            // 
            // pic_programming
            // 
            pic_programming.Image = (Image)resources.GetObject("pic_programming.Image");
            pic_programming.Location = new Point(12, 244);
            pic_programming.Name = "pic_programming";
            pic_programming.Size = new Size(43, 32);
            pic_programming.SizeMode = PictureBoxSizeMode.Zoom;
            pic_programming.TabIndex = 4;
            pic_programming.TabStop = false;
            pic_programming.Click += pic_programming_Click;
            // 
            // pic_Exist
            // 
            pic_Exist.Image = (Image)resources.GetObject("pic_Exist.Image");
            pic_Exist.Location = new Point(12, 398);
            pic_Exist.Name = "pic_Exist";
            pic_Exist.Size = new Size(43, 32);
            pic_Exist.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Exist.TabIndex = 3;
            pic_Exist.TabStop = false;
            // 
            // pic_reporting
            // 
            pic_reporting.Image = (Image)resources.GetObject("pic_reporting.Image");
            pic_reporting.Location = new Point(12, 197);
            pic_reporting.Name = "pic_reporting";
            pic_reporting.Size = new Size(43, 27);
            pic_reporting.SizeMode = PictureBoxSizeMode.Zoom;
            pic_reporting.TabIndex = 2;
            pic_reporting.TabStop = false;
            pic_reporting.Click += pic_reporting_Click;
            // 
            // pic_Educating
            // 
            pic_Educating.Image = (Image)resources.GetObject("pic_Educating.Image");
            pic_Educating.Location = new Point(12, 296);
            pic_Educating.Name = "pic_Educating";
            pic_Educating.Size = new Size(43, 34);
            pic_Educating.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Educating.TabIndex = 1;
            pic_Educating.TabStop = false;
            pic_Educating.Click += pic_Educating_Click;
            // 
            // pic_FillCircle
            // 
            pic_FillCircle.Location = new Point(12, 14);
            pic_FillCircle.Name = "pic_FillCircle";
            pic_FillCircle.Size = new Size(43, 29);
            pic_FillCircle.SizeMode = PictureBoxSizeMode.Zoom;
            pic_FillCircle.TabIndex = 0;
            pic_FillCircle.TabStop = false;
            // 
            // Questions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 611);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Questions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_QuestionBank).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Helping).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_programming).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Exist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_reporting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Educating).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_FillCircle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lab_Student;
        private Label lab_Subject;
        private Label lab_Question;
        private Label lab_header;
        private TextBox txt_question;
        private Label lab_quastion;
        private Label lab_option3;
        private Label lab_option1;
        private Label lab_option2;
        private Label lab_option5;
        private Label lab_option4;
        private TextBox txt_option5;
        private TextBox txt_option4;
        private TextBox txt_option3;
        private TextBox txt_option2;
        private TextBox txt_option1;
        private ComboBox com_Subject;
        private Button btn_Save;
        private DataGridView dataGrid_QuestionBank;
        private Button btn_Reset;
        private Button btn_Edit;
        private Label lab_QuestionBank;
        private PictureBox pic_Helping;
        private PictureBox pic_programming;
        private PictureBox pic_Exist;
        private PictureBox pic_reporting;
        private PictureBox pic_Educating;
        private PictureBox pic_FillCircle;
    }
}