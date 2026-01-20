namespace OnlineTutorHiringSystem
{
    partial class GuardianDashboard
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
            this.components = new System.ComponentModel.Container();
            this.signUpDataSet = new OnlineTutorHiringSystem.SignUpDataSet();
            this.signUpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUPDATETable = new OnlineTutorHiringSystem.TUPDATETable();
            this.tUPDATETableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeacherName = new System.Windows.Forms.Label();
            this.TeacherPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherNamebox = new System.Windows.Forms.TextBox();
            this.TeacherPhoneTextBox = new System.Windows.Forms.TextBox();
            this.TeacherEmailTextBox = new System.Windows.Forms.TextBox();
            this.RequestTeacher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUPDATETable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUPDATETableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpDataSet
            // 
            this.signUpDataSet.DataSetName = "SignUpDataSet";
            this.signUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // signUpDataSetBindingSource
            // 
            this.signUpDataSetBindingSource.DataSource = this.signUpDataSet;
            this.signUpDataSetBindingSource.Position = 0;
            // 
            // tUPDATETable
            // 
            this.tUPDATETable.DataSetName = "TUPDATETable";
            this.tUPDATETable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUPDATETableBindingSource
            // 
            this.tUPDATETableBindingSource.DataSource = this.tUPDATETable;
            this.tUPDATETableBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSize = true;
            this.TeacherName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherName.Location = new System.Drawing.Point(12, 90);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(104, 17);
            this.TeacherName.TabIndex = 1;
            this.TeacherName.Text = "Teacher\'s Name";
            // 
            // TeacherPhone
            // 
            this.TeacherPhone.AutoSize = true;
            this.TeacherPhone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherPhone.Location = new System.Drawing.Point(12, 127);
            this.TeacherPhone.Name = "TeacherPhone";
            this.TeacherPhone.Size = new System.Drawing.Size(161, 17);
            this.TeacherPhone.TabIndex = 2;
            this.TeacherPhone.Text = "Teacher\'s Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teacher\'s Email";
            // 
            // TeacherNamebox
            // 
            this.TeacherNamebox.Location = new System.Drawing.Point(189, 84);
            this.TeacherNamebox.Name = "TeacherNamebox";
            this.TeacherNamebox.Size = new System.Drawing.Size(171, 22);
            this.TeacherNamebox.TabIndex = 4;
            this.TeacherNamebox.TextChanged += new System.EventHandler(this.TeacherNamebox_TextChanged);
            // 
            // TeacherPhoneTextBox
            // 
            this.TeacherPhoneTextBox.Location = new System.Drawing.Point(189, 121);
            this.TeacherPhoneTextBox.Name = "TeacherPhoneTextBox";
            this.TeacherPhoneTextBox.Size = new System.Drawing.Size(171, 22);
            this.TeacherPhoneTextBox.TabIndex = 5;
            this.TeacherPhoneTextBox.TextChanged += new System.EventHandler(this.TeacherPhoneTextBox_TextChanged);
            // 
            // TeacherEmailTextBox
            // 
            this.TeacherEmailTextBox.Location = new System.Drawing.Point(189, 160);
            this.TeacherEmailTextBox.Name = "TeacherEmailTextBox";
            this.TeacherEmailTextBox.Size = new System.Drawing.Size(171, 22);
            this.TeacherEmailTextBox.TabIndex = 6;
            this.TeacherEmailTextBox.TextChanged += new System.EventHandler(this.TeacherEmailTextBox_TextChanged);
            // 
            // RequestTeacher
            // 
            this.RequestTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RequestTeacher.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestTeacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RequestTeacher.Location = new System.Drawing.Point(822, 111);
            this.RequestTeacher.Name = "RequestTeacher";
            this.RequestTeacher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RequestTeacher.Size = new System.Drawing.Size(176, 45);
            this.RequestTeacher.TabIndex = 7;
            this.RequestTeacher.Text = "Request Teacher";
            this.RequestTeacher.UseVisualStyleBackColor = false;
            this.RequestTeacher.Click += new System.EventHandler(this.RequestTeacher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Guardian Dashboard ";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExitButton.Location = new System.Drawing.Point(39, 18);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(58, 34);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(909, 31);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 35);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GuardianDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 559);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestTeacher);
            this.Controls.Add(this.TeacherEmailTextBox);
            this.Controls.Add(this.TeacherPhoneTextBox);
            this.Controls.Add(this.TeacherNamebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherPhone);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GuardianDashboard";
            this.Text = "Guardian Dashboard";
            this.Load += new System.EventHandler(this.GuardianDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUPDATETable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUPDATETableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource signUpDataSetBindingSource;
        private SignUpDataSet signUpDataSet;
        private System.Windows.Forms.BindingSource tUPDATETableBindingSource;
        private TUPDATETable tUPDATETable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TeacherName;
        private System.Windows.Forms.Label TeacherPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeacherNamebox;
        private System.Windows.Forms.TextBox TeacherPhoneTextBox;
        private System.Windows.Forms.TextBox TeacherEmailTextBox;
        private System.Windows.Forms.Button RequestTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
    }
}