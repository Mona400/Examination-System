namespace Exam_System
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pic_Helping = new PictureBox();
            pic_Exist = new PictureBox();
            lab_QuestionBank = new Label();
            dataGrid_StudentList = new DataGridView();
            btn_Reset = new Button();
            btn_Edit = new Button();
            btn_Save = new Button();
            txt_Phone = new TextBox();
            txt_Password = new TextBox();
            txt_Address = new TextBox();
            txt_Age = new TextBox();
            lab_option5 = new Label();
            lab_Phone = new Label();
            pic_programming = new PictureBox();
            pic_reporting = new PictureBox();
            pic_FillCircle = new PictureBox();
            lab_Password = new Label();
            lab_Age = new Label();
            lab_Address = new Label();
            txt_Name = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lab_header = new Label();
            panel3 = new Panel();
            pic_Educating = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lab_Name = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Helping).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Exist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_StudentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_programming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_reporting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_FillCircle).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Educating).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pic_Helping
            // 
            pic_Helping.Image = (Image)resources.GetObject("pic_Helping.Image");
            pic_Helping.Location = new Point(4, 336);
            pic_Helping.Name = "pic_Helping";
            pic_Helping.Size = new Size(43, 30);
            pic_Helping.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Helping.TabIndex = 5;
            pic_Helping.TabStop = false;
            // 
            // pic_Exist
            // 
            pic_Exist.Image = (Image)resources.GetObject("pic_Exist.Image");
            pic_Exist.Location = new Point(-1, 398);
            pic_Exist.Name = "pic_Exist";
            pic_Exist.Size = new Size(43, 32);
            pic_Exist.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Exist.TabIndex = 3;
            pic_Exist.TabStop = false;
            // 
            // lab_QuestionBank
            // 
            lab_QuestionBank.AutoSize = true;
            lab_QuestionBank.Font = new Font("Arial Unicode MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lab_QuestionBank.Location = new Point(389, 294);
            lab_QuestionBank.Name = "lab_QuestionBank";
            lab_QuestionBank.Size = new Size(172, 36);
            lab_QuestionBank.TabIndex = 23;
            lab_QuestionBank.Text = "Student List";
            // 
            // dataGrid_StudentList
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGrid_StudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid_StudentList.BackgroundColor = Color.White;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGrid_StudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid_StudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGrid_StudentList.DefaultCellStyle = dataGridViewCellStyle3;
            dataGrid_StudentList.Location = new Point(0, 363);
            dataGrid_StudentList.Name = "dataGrid_StudentList";
            dataGrid_StudentList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Silver;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGrid_StudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGrid_StudentList.RowTemplate.Height = 25;
            dataGrid_StudentList.Size = new Size(1133, 278);
            dataGrid_StudentList.TabIndex = 22;
            dataGrid_StudentList.CellClick += dataGrid_StudentList_CellContentClick;
            dataGrid_StudentList.CellContentClick += dataGrid_StudentList_CellContentClick;
            dataGrid_StudentList.CellContentDoubleClick += dataGrid_StudentList_CellContentClick;
            // 
            // btn_Reset
            // 
            btn_Reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Reset.Location = new Point(609, 256);
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
            btn_Edit.Location = new Point(416, 256);
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
            btn_Save.Location = new Point(226, 256);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(122, 36);
            btn_Save.TabIndex = 19;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // txt_Phone
            // 
            txt_Phone.BackColor = Color.FromArgb(255, 192, 192);
            txt_Phone.BorderStyle = BorderStyle.FixedSingle;
            txt_Phone.Location = new Point(578, 209);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(197, 23);
            txt_Phone.TabIndex = 16;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.FromArgb(255, 192, 192);
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Location = new Point(245, 209);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(197, 23);
            txt_Password.TabIndex = 15;
            // 
            // txt_Address
            // 
            txt_Address.BackColor = Color.FromArgb(255, 192, 192);
            txt_Address.BorderStyle = BorderStyle.FixedSingle;
            txt_Address.Location = new Point(708, 142);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(197, 23);
            txt_Address.TabIndex = 14;
            // 
            // txt_Age
            // 
            txt_Age.BackColor = Color.FromArgb(255, 192, 192);
            txt_Age.BorderStyle = BorderStyle.FixedSingle;
            txt_Age.Location = new Point(414, 142);
            txt_Age.Name = "txt_Age";
            txt_Age.Size = new Size(197, 23);
            txt_Age.TabIndex = 13;
            // 
            // lab_option5
            // 
            lab_option5.AutoSize = true;
            lab_option5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_option5.ForeColor = SystemColors.GrayText;
            lab_option5.Location = new Point(708, 168);
            lab_option5.Name = "lab_option5";
            lab_option5.Size = new Size(0, 21);
            lab_option5.TabIndex = 12;
            // 
            // lab_Phone
            // 
            lab_Phone.AutoSize = true;
            lab_Phone.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Phone.ForeColor = SystemColors.GrayText;
            lab_Phone.Location = new Point(580, 180);
            lab_Phone.Name = "lab_Phone";
            lab_Phone.Size = new Size(63, 21);
            lab_Phone.TabIndex = 11;
            lab_Phone.Text = "Phone:";
            // 
            // pic_programming
            // 
            pic_programming.Image = (Image)resources.GetObject("pic_programming.Image");
            pic_programming.Location = new Point(-1, 244);
            pic_programming.Name = "pic_programming";
            pic_programming.Size = new Size(43, 32);
            pic_programming.SizeMode = PictureBoxSizeMode.Zoom;
            pic_programming.TabIndex = 4;
            pic_programming.TabStop = false;
            pic_programming.Click += pic_programming_Click;
            // 
            // pic_reporting
            // 
            pic_reporting.Image = (Image)resources.GetObject("pic_reporting.Image");
            pic_reporting.Location = new Point(-1, 197);
            pic_reporting.Name = "pic_reporting";
            pic_reporting.Size = new Size(43, 27);
            pic_reporting.SizeMode = PictureBoxSizeMode.Zoom;
            pic_reporting.TabIndex = 2;
            pic_reporting.TabStop = false;
            // 
            // pic_FillCircle
            // 
            pic_FillCircle.Location = new Point(4, 14);
            pic_FillCircle.Name = "pic_FillCircle";
            pic_FillCircle.Size = new Size(43, 29);
            pic_FillCircle.SizeMode = PictureBoxSizeMode.Zoom;
            pic_FillCircle.TabIndex = 0;
            pic_FillCircle.TabStop = false;
            // 
            // lab_Password
            // 
            lab_Password.AutoSize = true;
            lab_Password.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Password.ForeColor = SystemColors.GrayText;
            lab_Password.Location = new Point(245, 180);
            lab_Password.Name = "lab_Password";
            lab_Password.Size = new Size(89, 21);
            lab_Password.TabIndex = 10;
            lab_Password.Text = "Password:";
            // 
            // lab_Age
            // 
            lab_Age.AutoSize = true;
            lab_Age.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Age.ForeColor = SystemColors.GrayText;
            lab_Age.Location = new Point(414, 116);
            lab_Age.Name = "lab_Age";
            lab_Age.Size = new Size(44, 21);
            lab_Age.TabIndex = 9;
            lab_Age.Text = "Age:";
            // 
            // lab_Address
            // 
            lab_Address.AutoSize = true;
            lab_Address.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Address.ForeColor = SystemColors.GrayText;
            lab_Address.Location = new Point(708, 116);
            lab_Address.Name = "lab_Address";
            lab_Address.Size = new Size(77, 21);
            lab_Address.TabIndex = 8;
            lab_Address.Text = "Address:";
            // 
            // txt_Name
            // 
            txt_Name.BackColor = Color.FromArgb(255, 192, 192);
            txt_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Name.Location = new Point(81, 142);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(197, 23);
            txt_Name.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(458, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(136, 3);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(485, 53);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 4;
            label3.Text = "Students";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(351, 53);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 3;
            label2.Text = "Subjects";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 53);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 2;
            label1.Text = "Questions";
            label1.Click += label1_Click;
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
            panel3.Location = new Point(1117, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(62, 616);
            panel3.TabIndex = 0;
            // 
            // pic_Educating
            // 
            pic_Educating.Image = (Image)resources.GetObject("pic_Educating.Image");
            pic_Educating.Location = new Point(-1, 296);
            pic_Educating.Name = "pic_Educating";
            pic_Educating.Size = new Size(43, 34);
            pic_Educating.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Educating.TabIndex = 1;
            pic_Educating.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 592);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(lab_QuestionBank);
            panel2.Controls.Add(dataGrid_StudentList);
            panel2.Controls.Add(btn_Reset);
            panel2.Controls.Add(btn_Edit);
            panel2.Controls.Add(btn_Save);
            panel2.Controls.Add(txt_Phone);
            panel2.Controls.Add(txt_Password);
            panel2.Controls.Add(txt_Address);
            panel2.Controls.Add(txt_Age);
            panel2.Controls.Add(lab_option5);
            panel2.Controls.Add(lab_Phone);
            panel2.Controls.Add(lab_Password);
            panel2.Controls.Add(lab_Age);
            panel2.Controls.Add(lab_Address);
            panel2.Controls.Add(lab_Name);
            panel2.Controls.Add(txt_Name);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lab_header);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1118, 631);
            panel2.TabIndex = 0;
            // 
            // lab_Name
            // 
            lab_Name.AutoSize = true;
            lab_Name.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Name.ForeColor = SystemColors.GrayText;
            lab_Name.Location = new Point(81, 116);
            lab_Name.Name = "lab_Name";
            lab_Name.Size = new Size(60, 21);
            lab_Name.TabIndex = 7;
            lab_Name.Text = "Name:";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 592);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)pic_Helping).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Exist).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_StudentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_programming).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_reporting).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_FillCircle).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Educating).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_Helping;
        private PictureBox pic_Exist;
        private Label lab_QuestionBank;
        private DataGridView dataGrid_StudentList;
        private Button btn_Reset;
        private Button btn_Edit;
        private Button btn_Save;
        private TextBox txt_Phone;
        private TextBox txt_Password;
        private TextBox txt_Address;
        private TextBox txt_Age;
        private Label lab_option5;
        private Label lab_Phone;
        private PictureBox pic_programming;
        private PictureBox pic_reporting;
        private PictureBox pic_FillCircle;
        private Label lab_Password;
        private Label lab_Age;
        private Label lab_Address;
        private TextBox txt_Name;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lab_header;
        private Panel panel3;
        private PictureBox pic_Educating;
        private Panel panel1;
        private Panel panel2;
        private Label lab_Name;
    }
}