namespace Exam_System
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pic_programming = new PictureBox();
            label3 = new Label();
            progressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pic_programming).BeginInit();
            SuspendLayout();
            // 
            // pic_programming
            // 
            pic_programming.Image = (Image)resources.GetObject("pic_programming.Image");
            pic_programming.Location = new Point(87, 77);
            pic_programming.Name = "pic_programming";
            pic_programming.Size = new Size(288, 201);
            pic_programming.SizeMode = PictureBoxSizeMode.Zoom;
            pic_programming.TabIndex = 5;
            pic_programming.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(32, 19);
            label3.Name = "label3";
            label3.Size = new Size(428, 44);
            label3.TabIndex = 6;
            label3.Text = "Examination System";
            // 
            // progressBar
            // 
            progressBar.ForeColor = SystemColors.ControlDarkDark;
            progressBar.Location = new Point(32, 327);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(445, 10);
            progressBar.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(506, 359);
            Controls.Add(progressBar);
            Controls.Add(label3);
            Controls.Add(pic_programming);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pic_programming).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_programming;
        private Label label3;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
    }
}