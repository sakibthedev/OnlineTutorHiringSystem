namespace OnlineTutorHiringSystem
{
    partial class Guardian
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
            this.YourInfoG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.InstituitionName = new System.Windows.Forms.TextBox();
            this.InstitituionName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.YourAreaComboBox = new System.Windows.Forms.ComboBox();
            this.YourAreaName = new System.Windows.Forms.Label();
            this.startdtp = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.enddtp = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.phonetextbox = new System.Windows.Forms.TextBox();
            this.Gupdate_click = new System.Windows.Forms.Button();
            this.Skip_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YourInfoG
            // 
            this.YourInfoG.AutoSize = true;
            this.YourInfoG.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.YourInfoG.Location = new System.Drawing.Point(101, 204);
            this.YourInfoG.Name = "YourInfoG";
            this.YourInfoG.Size = new System.Drawing.Size(162, 28);
            this.YourInfoG.TabIndex = 3;
            this.YourInfoG.Text = "Your Informaton";
            this.YourInfoG.Click += new System.EventHandler(this.YourInfoG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label3.Location = new System.Drawing.Point(59, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.Location = new System.Drawing.Point(59, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label1.Location = new System.Drawing.Point(59, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Group.Location = new System.Drawing.Point(664, 388);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(58, 23);
            this.Group.TabIndex = 71;
            this.Group.Text = "Group";
            this.Group.Click += new System.EventHandler(this.Group_Click);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.Class.Location = new System.Drawing.Point(664, 329);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(48, 23);
            this.Class.TabIndex = 69;
            this.Class.Text = "Class";
            // 
            // InstituitionName
            // 
            this.InstituitionName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.InstituitionName.Location = new System.Drawing.Point(813, 270);
            this.InstituitionName.Name = "InstituitionName";
            this.InstituitionName.Size = new System.Drawing.Size(202, 22);
            this.InstituitionName.TabIndex = 68;
            this.InstituitionName.TextChanged += new System.EventHandler(this.InstituitionName_TextChanged);
            // 
            // InstitituionName
            // 
            this.InstitituionName.AutoSize = true;
            this.InstitituionName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.InstitituionName.Location = new System.Drawing.Point(664, 272);
            this.InstitituionName.Name = "InstitituionName";
            this.InstitituionName.Size = new System.Drawing.Size(143, 23);
            this.InstitituionName.TabIndex = 67;
            this.InstitituionName.Text = "Institution Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label6.Location = new System.Drawing.Point(702, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 28);
            this.label6.TabIndex = 66;
            this.label6.Text = "Your Educational Background";
            // 
            // YourAreaComboBox
            // 
            this.YourAreaComboBox.FormattingEnabled = true;
            this.YourAreaComboBox.Items.AddRange(new object[] {
            "Dhanmondi",
            "Banani",
            "Gulshan",
            "Farmgate",
            "Mohakhali",
            "Uttara",
            "Bashundhara"});
            this.YourAreaComboBox.Location = new System.Drawing.Point(813, 445);
            this.YourAreaComboBox.Name = "YourAreaComboBox";
            this.YourAreaComboBox.Size = new System.Drawing.Size(202, 24);
            this.YourAreaComboBox.TabIndex = 65;
            this.YourAreaComboBox.SelectedIndexChanged += new System.EventHandler(this.AvailableArea_SelectedIndexChanged);
            // 
            // YourAreaName
            // 
            this.YourAreaName.AutoSize = true;
            this.YourAreaName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourAreaName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.YourAreaName.Location = new System.Drawing.Point(664, 443);
            this.YourAreaName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YourAreaName.Name = "YourAreaName";
            this.YourAreaName.Size = new System.Drawing.Size(88, 23);
            this.YourAreaName.TabIndex = 64;
            this.YourAreaName.Text = "Your Area:";
            this.YourAreaName.Click += new System.EventHandler(this.label5_Click);
            // 
            // startdtp
            // 
            this.startdtp.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.startdtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startdtp.Location = new System.Drawing.Point(415, 281);
            this.startdtp.Margin = new System.Windows.Forms.Padding(2);
            this.startdtp.Name = "startdtp";
            this.startdtp.ShowUpDown = true;
            this.startdtp.Size = new System.Drawing.Size(195, 25);
            this.startdtp.TabIndex = 61;
            // 
            // enddtp
            // 
            this.enddtp.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorMini;
            this.enddtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.enddtp.Location = new System.Drawing.Point(415, 341);
            this.enddtp.Margin = new System.Windows.Forms.Padding(2);
            this.enddtp.Name = "enddtp";
            this.enddtp.ShowUpDown = true;
            this.enddtp.Size = new System.Drawing.Size(195, 25);
            this.enddtp.TabIndex = 62;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label30.Location = new System.Drawing.Point(413, 249);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 23);
            this.label30.TabIndex = 58;
            this.label30.Text = "Start Time From:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.Location = new System.Drawing.Point(415, 311);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(114, 23);
            this.label31.TabIndex = 59;
            this.label31.Text = "Start Time To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label4.Location = new System.Drawing.Point(425, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 57;
            this.label4.Text = "Your Availability";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Items.AddRange(new object[] {
            "Not Applicable (Class 1 to 8)",
            "Science",
            "Commerce ",
            "Arts"});
            this.GroupComboBox.Location = new System.Drawing.Point(813, 390);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(202, 24);
            this.GroupComboBox.TabIndex = 73;
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3 ",
            "Class 4",
            "Class 5",
            "Class 6",
            "Class 7",
            "Class 8",
            "Class 9",
            "Class 10",
            "Class 11",
            "Class 12"});
            this.ClassComboBox.Location = new System.Drawing.Point(813, 329);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(202, 24);
            this.ClassComboBox.TabIndex = 74;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(130, 270);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(180, 22);
            this.nametextbox.TabIndex = 75;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(130, 327);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(180, 22);
            this.emailtextbox.TabIndex = 76;
            this.emailtextbox.TextChanged += new System.EventHandler(this.emailtextbox_TextChanged);
            // 
            // phonetextbox
            // 
            this.phonetextbox.Location = new System.Drawing.Point(133, 388);
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.Size = new System.Drawing.Size(177, 22);
            this.phonetextbox.TabIndex = 77;
            this.phonetextbox.TextChanged += new System.EventHandler(this.phonetextbox_TextChanged);
            // 
            // Gupdate_click
            // 
            this.Gupdate_click.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.Gupdate_click.Location = new System.Drawing.Point(419, 439);
            this.Gupdate_click.Name = "Gupdate_click";
            this.Gupdate_click.Size = new System.Drawing.Size(177, 59);
            this.Gupdate_click.TabIndex = 78;
            this.Gupdate_click.Text = "UPDATE";
            this.Gupdate_click.UseVisualStyleBackColor = true;
            this.Gupdate_click.Click += new System.EventHandler(this.Gupdate_click_Click);
            // 
            // Skip_button
            // 
            this.Skip_button.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skip_button.Location = new System.Drawing.Point(35, 488);
            this.Skip_button.Name = "Skip_button";
            this.Skip_button.Size = new System.Drawing.Size(83, 31);
            this.Skip_button.TabIndex = 79;
            this.Skip_button.Text = "Skip";
            this.Skip_button.UseVisualStyleBackColor = true;
            this.Skip_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 54);
            this.label5.TabIndex = 80;
            this.label5.Text = "Welcome Guardian!";
            // 
            // Guardian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Skip_button);
            this.Controls.Add(this.Gupdate_click);
            this.Controls.Add(this.phonetextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.InstituitionName);
            this.Controls.Add(this.InstitituionName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YourAreaComboBox);
            this.Controls.Add(this.YourAreaName);
            this.Controls.Add(this.startdtp);
            this.Controls.Add(this.enddtp);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YourInfoG);
            this.Name = "Guardian";
            this.Text = "Guardian Dashboard";
            this.Load += new System.EventHandler(this.Guardian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YourInfoG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Group;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.TextBox InstituitionName;
        private System.Windows.Forms.Label InstitituionName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox YourAreaComboBox;
        private System.Windows.Forms.Label YourAreaName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker startdtp;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker enddtp;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox phonetextbox;
        private System.Windows.Forms.Button Gupdate_click;
        private System.Windows.Forms.Button Skip_button;
        private System.Windows.Forms.Label label5;
    }
}