namespace OnlineTutorHiringSystem
{
    partial class Teacher
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
            this.Hello = new System.Windows.Forms.Label();
            this.YourInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startdtp = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.enddtp = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ExpectedSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AvailableArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.InstituitionName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProgramName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CGPA = new System.Windows.Forms.TextBox();
            this.Update_click = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Skip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.Hello.Location = new System.Drawing.Point(289, 30);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(445, 67);
            this.Hello.TabIndex = 1;
            this.Hello.Text = "Welcome Teacher!";
            this.Hello.Click += new System.EventHandler(this.Hello_Click);
            // 
            // YourInfo
            // 
            this.YourInfo.AutoSize = true;
            this.YourInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.YourInfo.Location = new System.Drawing.Point(70, 166);
            this.YourInfo.Name = "YourInfo";
            this.YourInfo.Size = new System.Drawing.Size(162, 28);
            this.YourInfo.TabIndex = 2;
            this.YourInfo.Text = "Your Informaton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label1.Location = new System.Drawing.Point(26, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.Location = new System.Drawing.Point(26, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label3.Location = new System.Drawing.Point(26, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label4.Location = new System.Drawing.Point(449, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Your Availability";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // startdtp
            // 
            this.startdtp.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.startdtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startdtp.Location = new System.Drawing.Point(432, 259);
            this.startdtp.Margin = new System.Windows.Forms.Padding(2);
            this.startdtp.Name = "startdtp";
            this.startdtp.ShowUpDown = true;
            this.startdtp.Size = new System.Drawing.Size(195, 25);
            this.startdtp.TabIndex = 42;
            this.startdtp.ValueChanged += new System.EventHandler(this.startdtp_ValueChanged);
            // 
            // enddtp
            // 
            this.enddtp.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.enddtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.enddtp.Location = new System.Drawing.Point(432, 319);
            this.enddtp.Margin = new System.Windows.Forms.Padding(2);
            this.enddtp.Name = "enddtp";
            this.enddtp.ShowUpDown = true;
            this.enddtp.Size = new System.Drawing.Size(195, 25);
            this.enddtp.TabIndex = 43;
            this.enddtp.ValueChanged += new System.EventHandler(this.enddtp_ValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label30.Location = new System.Drawing.Point(430, 227);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 23);
            this.label30.TabIndex = 38;
            this.label30.Text = "Start Time:";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.Location = new System.Drawing.Point(432, 289);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 23);
            this.label31.TabIndex = 39;
            this.label31.Text = "End Time:";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label29.Location = new System.Drawing.Point(432, 349);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(136, 23);
            this.label29.TabIndex = 40;
            this.label29.Text = "Expected Salary:";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // ExpectedSalary
            // 
            this.ExpectedSalary.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ExpectedSalary.Location = new System.Drawing.Point(434, 380);
            this.ExpectedSalary.Name = "ExpectedSalary";
            this.ExpectedSalary.Size = new System.Drawing.Size(192, 22);
            this.ExpectedSalary.TabIndex = 44;
            this.ExpectedSalary.TextChanged += new System.EventHandler(this.ExpectedSalary_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(432, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Available Area:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AvailableArea
            // 
            this.AvailableArea.FormattingEnabled = true;
            this.AvailableArea.Location = new System.Drawing.Point(432, 446);
            this.AvailableArea.Name = "AvailableArea";
            this.AvailableArea.Size = new System.Drawing.Size(195, 24);
            this.AvailableArea.TabIndex = 47;
            this.AvailableArea.SelectedIndexChanged += new System.EventHandler(this.AvailableArea_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label6.Location = new System.Drawing.Point(719, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 28);
            this.label6.TabIndex = 48;
            this.label6.Text = "Your Educational Background";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label7.Location = new System.Drawing.Point(681, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 49;
            this.label7.Text = "Institution Name:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // InstituitionName
            // 
            this.InstituitionName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.InstituitionName.Location = new System.Drawing.Point(830, 248);
            this.InstituitionName.Name = "InstituitionName";
            this.InstituitionName.Size = new System.Drawing.Size(202, 22);
            this.InstituitionName.TabIndex = 50;
            this.InstituitionName.TextChanged += new System.EventHandler(this.InstituitionName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label8.Location = new System.Drawing.Point(681, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "Program";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ProgramName
            // 
            this.ProgramName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ProgramName.Location = new System.Drawing.Point(830, 309);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(202, 22);
            this.ProgramName.TabIndex = 52;
            this.ProgramName.TextChanged += new System.EventHandler(this.ProgramName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label9.Location = new System.Drawing.Point(681, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 53;
            this.label9.Text = "Semester";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Semester
            // 
            this.Semester.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Semester.Location = new System.Drawing.Point(830, 366);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(202, 22);
            this.Semester.TabIndex = 54;
            this.Semester.TextChanged += new System.EventHandler(this.Semester_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label10.Location = new System.Drawing.Point(681, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 55;
            this.label10.Text = "CGPA";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // CGPA
            // 
            this.CGPA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CGPA.Location = new System.Drawing.Point(830, 419);
            this.CGPA.Name = "CGPA";
            this.CGPA.Size = new System.Drawing.Size(202, 22);
            this.CGPA.TabIndex = 56;
            this.CGPA.TextChanged += new System.EventHandler(this.CGPA_TextChanged);
            // 
            // Update_click
            // 
            this.Update_click.BackColor = System.Drawing.Color.DarkViolet;
            this.Update_click.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.Update_click.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_click.Location = new System.Drawing.Point(469, 496);
            this.Update_click.Name = "Update_click";
            this.Update_click.Size = new System.Drawing.Size(148, 70);
            this.Update_click.TabIndex = 57;
            this.Update_click.Text = "Update";
            this.Update_click.UseVisualStyleBackColor = false;
            this.Update_click.Click += new System.EventHandler(this.Update_click_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 58;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox3.Location = new System.Drawing.Point(103, 368);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Location = new System.Drawing.Point(103, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Skip
            // 
            this.Skip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Skip.Location = new System.Drawing.Point(30, 527);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(98, 38);
            this.Skip.TabIndex = 60;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = false;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1089, 605);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Update_click);
            this.Controls.Add(this.CGPA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProgramName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InstituitionName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AvailableArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExpectedSalary);
            this.Controls.Add(this.startdtp);
            this.Controls.Add(this.enddtp);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YourInfo);
            this.Controls.Add(this.Hello);
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Update";
            this.Load += new System.EventHandler(this.Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.Label YourInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker startdtp;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker enddtp;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox ExpectedSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AvailableArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InstituitionName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProgramName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Semester;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CGPA;
        private System.Windows.Forms.Button Update_click;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Skip;
    }
}