namespace OnlineTutorHiringSystem
{
    partial class TeacherDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRequestsForTeacher = new System.Windows.Forms.DataGridView();
            this.RequestedStudents = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsForTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teacher Dashboard";
            // 
            // dataGridViewRequestsForTeacher
            // 
            this.dataGridViewRequestsForTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestsForTeacher.Location = new System.Drawing.Point(4, 257);
            this.dataGridViewRequestsForTeacher.Name = "dataGridViewRequestsForTeacher";
            this.dataGridViewRequestsForTeacher.RowHeadersWidth = 51;
            this.dataGridViewRequestsForTeacher.RowTemplate.Height = 24;
            this.dataGridViewRequestsForTeacher.Size = new System.Drawing.Size(1048, 454);
            this.dataGridViewRequestsForTeacher.TabIndex = 4;
            // 
            // RequestedStudents
            // 
            this.RequestedStudents.AutoSize = true;
            this.RequestedStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestedStudents.Location = new System.Drawing.Point(12, 220);
            this.RequestedStudents.Name = "RequestedStudents";
            this.RequestedStudents.Size = new System.Drawing.Size(220, 25);
            this.RequestedStudents.TabIndex = 5;
            this.RequestedStudents.Text = "Requested Students: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note: Call the students for get hired";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Location = new System.Drawing.Point(26, 25);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(69, 34);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Blue;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.Location = new System.Drawing.Point(907, 159);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 47);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back ";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1064, 723);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestedStudents);
            this.Controls.Add(this.dataGridViewRequestsForTeacher);
            this.Controls.Add(this.label1);
            this.Name = "TeacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Dashboard";
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsForTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRequestsForTeacher;
        private System.Windows.Forms.Label RequestedStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button backButton;
    }
}