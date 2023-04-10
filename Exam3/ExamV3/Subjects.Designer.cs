namespace Exam_System
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_SubjectList = new System.Windows.Forms.Label();
            this.dataGrid_SubjectList = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_SubjectName = new System.Windows.Forms.TextBox();
            this.lab_subjectName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lab_Student = new System.Windows.Forms.Label();
            this.lab_Subject = new System.Windows.Forms.Label();
            this.lab_Question = new System.Windows.Forms.Label();
            this.lab_header = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_Helping = new System.Windows.Forms.PictureBox();
            this.pic_programming = new System.Windows.Forms.PictureBox();
            this.pic_Exist = new System.Windows.Forms.PictureBox();
            this.pic_reporting = new System.Windows.Forms.PictureBox();
            this.pic_Educating = new System.Windows.Forms.PictureBox();
            this.pic_FillCircle = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_SubjectList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Helping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_programming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reporting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Educating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FillCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 631);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lab_SubjectList);
            this.panel2.Controls.Add(this.dataGrid_SubjectList);
            this.panel2.Controls.Add(this.btn_Reset);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.txt_SubjectName);
            this.panel2.Controls.Add(this.lab_subjectName);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lab_Student);
            this.panel2.Controls.Add(this.lab_Subject);
            this.panel2.Controls.Add(this.lab_Question);
            this.panel2.Controls.Add(this.lab_header);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 631);
            this.panel2.TabIndex = 0;
            // 
            // lab_SubjectList
            // 
            this.lab_SubjectList.AutoSize = true;
            this.lab_SubjectList.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_SubjectList.Location = new System.Drawing.Point(389, 294);
            this.lab_SubjectList.Name = "lab_SubjectList";
            this.lab_SubjectList.Size = new System.Drawing.Size(184, 36);
            this.lab_SubjectList.TabIndex = 23;
            this.lab_SubjectList.Text = "Subjects List";
            // 
            // dataGrid_SubjectList
            // 
            this.dataGrid_SubjectList.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_SubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_SubjectList.Location = new System.Drawing.Point(0, 333);
            this.dataGrid_SubjectList.Name = "dataGrid_SubjectList";
            this.dataGrid_SubjectList.RowTemplate.Height = 25;
            this.dataGrid_SubjectList.Size = new System.Drawing.Size(1126, 298);
            this.dataGrid_SubjectList.TabIndex = 22;
            this.dataGrid_SubjectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_SubjectList_CellContentClick);
            this.dataGrid_SubjectList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_SubjectList_CellContentClick);
            this.dataGrid_SubjectList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_SubjectList_CellContentClick);
            this.dataGrid_SubjectList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_SubjectList_CellContentClick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(582, 212);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(134, 36);
            this.btn_Reset.TabIndex = 21;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Edit.Location = new System.Drawing.Point(389, 212);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(127, 36);
            this.btn_Edit.TabIndex = 20;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(199, 212);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(122, 36);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_SubjectName
            // 
            this.txt_SubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_SubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SubjectName.Location = new System.Drawing.Point(321, 160);
            this.txt_SubjectName.Name = "txt_SubjectName";
            this.txt_SubjectName.Size = new System.Drawing.Size(197, 23);
            this.txt_SubjectName.TabIndex = 13;
            // 
            // lab_subjectName
            // 
            this.lab_subjectName.AutoSize = true;
            this.lab_subjectName.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_subjectName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lab_subjectName.Location = new System.Drawing.Point(321, 116);
            this.lab_subjectName.Name = "lab_subjectName";
            this.lab_subjectName.Size = new System.Drawing.Size(124, 21);
            this.lab_subjectName.TabIndex = 9;
            this.lab_subjectName.Text = "Subject Name ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(321, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 3);
            this.panel4.TabIndex = 5;
            // 
            // lab_Student
            // 
            this.lab_Student.AutoSize = true;
            this.lab_Student.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_Student.Location = new System.Drawing.Point(485, 53);
            this.lab_Student.Name = "lab_Student";
            this.lab_Student.Size = new System.Drawing.Size(78, 23);
            this.lab_Student.TabIndex = 4;
            this.lab_Student.Text = "Students";
            this.lab_Student.Click += new System.EventHandler(this.lab_Student_Click);
            // 
            // lab_Subject
            // 
            this.lab_Subject.AutoSize = true;
            this.lab_Subject.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_Subject.Location = new System.Drawing.Point(351, 53);
            this.lab_Subject.Name = "lab_Subject";
            this.lab_Subject.Size = new System.Drawing.Size(76, 23);
            this.lab_Subject.TabIndex = 3;
            this.lab_Subject.Text = "Subjects";
            this.lab_Subject.Click += new System.EventHandler(this.lab_Subject_Click);
            // 
            // lab_Question
            // 
            this.lab_Question.AutoSize = true;
            this.lab_Question.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_Question.Location = new System.Drawing.Point(210, 53);
            this.lab_Question.Name = "lab_Question";
            this.lab_Question.Size = new System.Drawing.Size(88, 23);
            this.lab_Question.TabIndex = 2;
            this.lab_Question.Text = "Questions";
            this.lab_Question.Click += new System.EventHandler(this.lab_Question_Click);
            // 
            // lab_header
            // 
            this.lab_header.AutoSize = true;
            this.lab_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_header.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_header.Location = new System.Drawing.Point(23, 18);
            this.lab_header.Name = "lab_header";
            this.lab_header.Size = new System.Drawing.Size(125, 25);
            this.lab_header.TabIndex = 1;
            this.lab_header.Text = "Exam System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.pic_Helping);
            this.panel3.Controls.Add(this.pic_programming);
            this.panel3.Controls.Add(this.pic_Exist);
            this.panel3.Controls.Add(this.pic_reporting);
            this.panel3.Controls.Add(this.pic_Educating);
            this.panel3.Controls.Add(this.pic_FillCircle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1125, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 631);
            this.panel3.TabIndex = 0;
            // 
            // pic_Helping
            // 
            this.pic_Helping.Image = ((System.Drawing.Image)(resources.GetObject("pic_Helping.Image")));
            this.pic_Helping.Location = new System.Drawing.Point(12, 344);
            this.pic_Helping.Name = "pic_Helping";
            this.pic_Helping.Size = new System.Drawing.Size(43, 30);
            this.pic_Helping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Helping.TabIndex = 5;
            this.pic_Helping.TabStop = false;
            // 
            // pic_programming
            // 
            this.pic_programming.Image = ((System.Drawing.Image)(resources.GetObject("pic_programming.Image")));
            this.pic_programming.Location = new System.Drawing.Point(12, 244);
            this.pic_programming.Name = "pic_programming";
            this.pic_programming.Size = new System.Drawing.Size(43, 32);
            this.pic_programming.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_programming.TabIndex = 4;
            this.pic_programming.TabStop = false;
            // 
            // pic_Exist
            // 
            this.pic_Exist.Image = ((System.Drawing.Image)(resources.GetObject("pic_Exist.Image")));
            this.pic_Exist.Location = new System.Drawing.Point(12, 398);
            this.pic_Exist.Name = "pic_Exist";
            this.pic_Exist.Size = new System.Drawing.Size(43, 32);
            this.pic_Exist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exist.TabIndex = 3;
            this.pic_Exist.TabStop = false;
            // 
            // pic_reporting
            // 
            this.pic_reporting.Image = ((System.Drawing.Image)(resources.GetObject("pic_reporting.Image")));
            this.pic_reporting.Location = new System.Drawing.Point(12, 197);
            this.pic_reporting.Name = "pic_reporting";
            this.pic_reporting.Size = new System.Drawing.Size(43, 27);
            this.pic_reporting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_reporting.TabIndex = 2;
            this.pic_reporting.TabStop = false;
            this.pic_reporting.Click += new System.EventHandler(this.pic_reporting_Click);
            // 
            // pic_Educating
            // 
            this.pic_Educating.Image = ((System.Drawing.Image)(resources.GetObject("pic_Educating.Image")));
            this.pic_Educating.Location = new System.Drawing.Point(12, 296);
            this.pic_Educating.Name = "pic_Educating";
            this.pic_Educating.Size = new System.Drawing.Size(43, 34);
            this.pic_Educating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Educating.TabIndex = 1;
            this.pic_Educating.TabStop = false;
            this.pic_Educating.Click += new System.EventHandler(this.pic_Educating_Click);
            // 
            // pic_FillCircle
            // 
          
            this.pic_FillCircle.Location = new System.Drawing.Point(12, 14);
            this.pic_FillCircle.Name = "pic_FillCircle";
            this.pic_FillCircle.Size = new System.Drawing.Size(43, 29);
            this.pic_FillCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_FillCircle.TabIndex = 0;
            this.pic_FillCircle.TabStop = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 631);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_SubjectList)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Helping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_programming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_reporting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Educating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FillCircle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label lab_SubjectList;
        private DataGridView dataGrid_SubjectList;
        private Button btn_Reset;
        private Button btn_Edit;
        private Button btn_Save;
        private TextBox txt_SubjectName;
        private Label lab_subjectName;
        private Panel panel4;
        private Label lab_Student;
        private Label lab_Subject;
        private Label lab_Question;
        private Label lab_header;
        private Panel panel3;
        private PictureBox pic_Helping;
        private PictureBox pic_programming;
        private PictureBox pic_Exist;
        private PictureBox pic_reporting;
        private PictureBox pic_Educating;
        private PictureBox pic_FillCircle;
    }
}