using ComponentFactory.Krypton.Toolkit;
using OnlineTutorHiringSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineTutorHiringSystem
{
    public partial class Teacher : KryptonForm
    {
        private int teacherId;
        public Teacher()
        {
            InitializeComponent();
            LoadProfilePic();
            LoadCaretakerInformation();
        }

        private void CaretakersPanel_Load(object sender, EventArgs e)
        {
            LoadCaretakerInformation();
            LoadBookings();
            LoadProfilePic();
        }

        string currentPassword = string.Empty;
        public void LoadCaretakerInformation()
        {
            try
            {
                // Database call commented out
                // var query = $"SELECT * FROM daycare_db.caretakers Where CaretakerId = '{caretakerId}'";
                // DataTable dt = DataAccess.getData(query);

                // Dummy data to prevent errors
                currentPassword = "Password123";

                TeacherName.Text = "Caretaker Name";
                nameLbl.Text = "Caretaker Name";

                emailLbl.Text = "email@example.com";
                email.Text = "email@example.com";

                phoneLbl.Text = "017XXXXXXXX";
                phone.Text = "017XXXXXXXX";

                addressLbl.Text = "Address";
                address.Text = "Address";

                string from = "09:00";
                string to = "18:00";
                fee.Text = "500";

                TimeSpan startTime = TimeSpan.Parse(from);
                TimeSpan endTime = TimeSpan.Parse(to);

                startdtp.Value = DateTime.Today.Add(startTime);
                enddtp.Value = DateTime.Today.Add(endTime);
                feetlbl.Text = "500";

                int isVerified = 1;

                verified.Text = isVerified == 1 ? "Yes" : "No";

                Sazid.Text = "Caretaker Name";
                start.Text = startTime.ToString(@"hh\:mm");
                end.Text = endTime.ToString(@"hh\:mm");
                start.Visible = true;
                end.Visible = true;
                fee.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading caretaker info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void LoadBookings()
        {
            try
            {
                // Database call commented out
                // var query = "...";
                // DataTable dt = DataAccess.getData(query);
                // Bookings.AutoGenerateColumns = false;
                // Bookings.DataSource = dt;
                // Bookings.Refresh();
                // Bookings.ClearSelection();

                // Dummy placeholder
                Bookings.DataSource = null;
            }
            catch (Exception ex)
            {

            }
        }

        public void newData()
        {
            childName.Visible = false;
            from.Visible = false;
            to.Visible = false;
            pending.Checked = false;
            accepted.Checked = false;
            cancelled.Checked = false;
        }

        string bookingId;
        string currentStatus = "Pending";
        private void Parents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            bookingId = "1"; // Dummy
            childName.Text = "Child Name";
            childName.Visible = true;
            from.Text = "09:00";
            from.Visible = true;
            to.Text = "18:00";
            to.Visible = true;
            string status = "Pending";
            if (status == "Pending")
            {
                pending.Checked = true;
                currentStatus = "Pending";
            }
            else if (status == "Accepted")
            {
                accepted.Checked = true;
                currentStatus = "Accepted";
            }
            else if (status == "Cancelled")
            {
                cancelled.Checked = true;
                currentStatus = "Cancelled";
            }
        }

        private void booking_Click(object sender, EventArgs e)
        {
            Bookings.Visible = true;
            YourInformationPanel.Visible = false;
            bookingsPanel.Visible = true;
            panel4.Visible = false;
            info.ForeColor = Color.Black;
            Update.ForeColor = Color.Black;
            booking.ForeColor = Color.Purple;
            profile.Visible = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // DB update commented out
            MessageBox.Show("Save_Click called (DB logic skipped).");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // DB delete commented out
            MessageBox.Show("Delete booking (DB logic skipped).");
        }

        private void info_Click(object sender, EventArgs e)
        {
            profile.Visible = false;
            YourInformationPanel.Visible = true;
            bookingsPanel.Visible = false;
            Bookings.Visible = false;
            panel4.Visible = false;
            info.ForeColor = Color.Purple;
            Update.ForeColor = Color.Black;
            booking.ForeColor = Color.Black;
            verified.Visible = true;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            YourInformationPanel.Visible = false;
            profile.Visible = true;
            Bookings.Visible = false;
            bookingsPanel.Visible = false;
            panel4.Visible = true;
            info.ForeColor = Color.Black;
            Update.ForeColor = Color.Purple;
            booking.ForeColor = Color.Black;
        }

        private void sup_Click(object sender, EventArgs e)
        {
            // DB update commented out
            MessageBox.Show("Update info (DB logic skipped).");
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                oldpass.PasswordChar = '\0';
                newpass.PasswordChar = '\0';
            }
            else
            {
                oldpass.PasswordChar = '*';
                newpass.PasswordChar = '*';
            }
        }

        private void oldpass_TextChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                oldpass.PasswordChar = '\0';
                newpass.PasswordChar = '\0';
            }
            else
            {
                oldpass.PasswordChar = '*';
                newpass.PasswordChar = '*';
            }
        }

        private void newpass_TextChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                oldpass.PasswordChar = '\0';
                newpass.PasswordChar = '\0';
            }
            else
            {
                oldpass.PasswordChar = '*';
                newpass.PasswordChar = '*';
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // DB update commented out
            MessageBox.Show("UpdateButton clicked (DB logic skipped).");
        }

        private void uploadProfilePic()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    profilepic.Image = Image.FromFile(ofd.FileName);
                    prp.Image = Image.FromFile(ofd.FileName);

                    // DB update commented out
                    MessageBox.Show("Profile picture updated (DB logic skipped).");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void LoadProfilePic()
        {
            // DB load commented out
            // Use placeholder
            profilepic.Image = null;
            prp.Image = null;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            uploadProfilePic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            Login loginForm = new Login();
            loginForm.Visible = true;
            this.Close();
        }

        private void TimeAvailable_Click(object sender, EventArgs e)
        {

        }

        private void caretakersName_Click(object sender, EventArgs e)
        {

        }

        private void Bookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void YourName_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
