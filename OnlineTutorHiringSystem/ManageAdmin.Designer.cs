namespace OnlineTutorHiringSystem
{
    partial class ManageAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mGinstituition = new System.Windows.Forms.Label();
            this.mGphone = new System.Windows.Forms.Label();
            this.mGemail = new System.Windows.Forms.Label();
            this.mGname = new System.Windows.Forms.Label();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.editPanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(31, 218);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(142, 38);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseMnemonic = false;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(490, 218);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(148, 38);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(919, 218);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(138, 37);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete ";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(936, 27);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(94, 41);
            this.LogOut.TabIndex = 4;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.Color.LightBlue;
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.CancelButton);
            this.editPanel.Controls.Add(this.SaveButton);
            this.editPanel.Controls.Add(this.textBox4);
            this.editPanel.Controls.Add(this.textBox3);
            this.editPanel.Controls.Add(this.textBox2);
            this.editPanel.Controls.Add(this.textBox1);
            this.editPanel.Controls.Add(this.mGinstituition);
            this.editPanel.Controls.Add(this.mGphone);
            this.editPanel.Controls.Add(this.mGemail);
            this.editPanel.Controls.Add(this.mGname);
            this.editPanel.Location = new System.Drawing.Point(254, 112);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(600, 402);
            this.editPanel.TabIndex = 5;
            this.editPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Edit Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(335, 329);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(139, 35);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(121, 328);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(133, 37);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(274, 221);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(274, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mGinstituition
            // 
            this.mGinstituition.AutoSize = true;
            this.mGinstituition.Location = new System.Drawing.Point(156, 224);
            this.mGinstituition.Name = "mGinstituition";
            this.mGinstituition.Size = new System.Drawing.Size(67, 16);
            this.mGinstituition.TabIndex = 3;
            this.mGinstituition.Text = "Password";
            // 
            // mGphone
            // 
            this.mGphone.AutoSize = true;
            this.mGphone.Location = new System.Drawing.Point(156, 194);
            this.mGphone.Name = "mGphone";
            this.mGphone.Size = new System.Drawing.Size(97, 16);
            this.mGphone.TabIndex = 2;
            this.mGphone.Text = "Phone Number";
            // 
            // mGemail
            // 
            this.mGemail.AutoSize = true;
            this.mGemail.Location = new System.Drawing.Point(156, 157);
            this.mGemail.Name = "mGemail";
            this.mGemail.Size = new System.Drawing.Size(41, 16);
            this.mGemail.TabIndex = 1;
            this.mGemail.Text = "Email";
            this.mGemail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mGname
            // 
            this.mGname.AutoSize = true;
            this.mGname.Location = new System.Drawing.Point(156, 121);
            this.mGname.Name = "mGname";
            this.mGname.Size = new System.Drawing.Size(44, 16);
            this.mGname.TabIndex = 0;
            this.mGname.Text = "Name";
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.LightBlue;
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.button1);
            this.AddPanel.Controls.Add(this.button2);
            this.AddPanel.Controls.Add(this.textBox5);
            this.AddPanel.Controls.Add(this.textBox6);
            this.AddPanel.Controls.Add(this.textBox7);
            this.AddPanel.Controls.Add(this.textBox8);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.label6);
            this.AddPanel.Location = new System.Drawing.Point(262, 120);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(600, 402);
            this.AddPanel.TabIndex = 6;
            this.AddPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add Admin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(274, 221);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 22);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(274, 187);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 22);
            this.textBox6.TabIndex = 8;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(274, 146);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(164, 22);
            this.textBox7.TabIndex = 7;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(274, 115);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(164, 22);
            this.textBox8.TabIndex = 6;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(31, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(79, 32);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1108, 627);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Admin";
            this.Load += new System.EventHandler(this.ManageAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label mGinstituition;
        private System.Windows.Forms.Label mGphone;
        private System.Windows.Forms.Label mGemail;
        private System.Windows.Forms.Label mGname;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BackButton;
    }
}