namespace OnlineTutorHiringSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.ManageGuardian = new System.Windows.Forms.Button();
            this.ManageTeacher = new System.Windows.Forms.Button();
            this.ManageAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageGuardian
            // 
            this.ManageGuardian.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ManageGuardian.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageGuardian.Location = new System.Drawing.Point(729, 114);
            this.ManageGuardian.Name = "ManageGuardian";
            this.ManageGuardian.Size = new System.Drawing.Size(313, 128);
            this.ManageGuardian.TabIndex = 0;
            this.ManageGuardian.Text = "Manage Guardian";
            this.ManageGuardian.UseVisualStyleBackColor = false;
            this.ManageGuardian.Click += new System.EventHandler(this.ManageGuardian_Click);
            // 
            // ManageTeacher
            // 
            this.ManageTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ManageTeacher.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageTeacher.Location = new System.Drawing.Point(730, 295);
            this.ManageTeacher.Name = "ManageTeacher";
            this.ManageTeacher.Size = new System.Drawing.Size(313, 132);
            this.ManageTeacher.TabIndex = 1;
            this.ManageTeacher.Text = "Manage Teacher";
            this.ManageTeacher.UseVisualStyleBackColor = false;
            this.ManageTeacher.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageAdmin
            // 
            this.ManageAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ManageAdmin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAdmin.Location = new System.Drawing.Point(734, 498);
            this.ManageAdmin.Name = "ManageAdmin";
            this.ManageAdmin.Size = new System.Drawing.Size(313, 143);
            this.ManageAdmin.TabIndex = 2;
            this.ManageAdmin.Text = "Manage Admin";
            this.ManageAdmin.UseVisualStyleBackColor = false;
            this.ManageAdmin.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to Admin Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 427);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1097, 752);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManageAdmin);
            this.Controls.Add(this.ManageTeacher);
            this.Controls.Add(this.ManageGuardian);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageGuardian;
        private System.Windows.Forms.Button ManageTeacher;
        private System.Windows.Forms.Button ManageAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}