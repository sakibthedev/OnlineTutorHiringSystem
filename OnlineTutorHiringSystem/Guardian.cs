using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineTutorHiringSystem
{
    public partial class Guardian : Form
    {
        // This line fixes the 'does not contain a definition' error
        public static string LoggedInGuardianEmail { get; set; }

        public Guardian()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Guardian_Load(object sender, EventArgs e)
        {
            // 1. Make textboxes read-only so users can't change info here
            nametextbox.ReadOnly = true;
            emailtextbox.ReadOnly = true;
            phonetextbox.ReadOnly = true;

            // 2. Load the data from database
            LoadGuardianData();
        }

        private void LoadGuardianData()
        {
            if (string.IsNullOrEmpty(LoggedInGuardianEmail)) return;

            // Cleaned up connection string formatting
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Gname, Gemail, Gnumber FROM GTable WHERE Gemail = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", LoggedInGuardianEmail);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nametextbox.Text = reader["Gname"].ToString();
                                emailtextbox.Text = reader["Gemail"].ToString();
                                phonetextbox.Text = reader["Gnumber"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile: " + ex.Message);
                }
            }
        }

        private void Gupdate_click_Click(object sender, EventArgs e)
        {
            // FIXED: Corrected variable name typo
            if (string.IsNullOrEmpty(LoggedInGuardianEmail))
            {
                MessageBox.Show("No guardian session found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Collect values
            string InsName = InstituitionName.Text.Trim();
            string Class = ClassComboBox.Text.Trim();
            string Group = GroupComboBox.Text.Trim();
            string YourArea = YourAreaComboBox.SelectedItem?.ToString();

            DateTime startTime = startdtp.Value;
            DateTime endTime = enddtp.Value;

            // FIXED: Removed undefined 'area' variable, replaced with 'YourArea'
            if (string.IsNullOrEmpty(InsName) || string.IsNullOrEmpty(Class) ||
                string.IsNullOrEmpty(Group) || string.IsNullOrEmpty(YourArea) || YourArea == "Select Area")
            {
                MessageBox.Show("Please fill all fields and select a valid area.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check if row exists
                    string checkQuery = "SELECT COUNT(*) FROM GUPDATETable WHERE Gemail = @Gemail";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        // FIXED: Corrected LoggedInGeacherEmail to LoggedInGuardianEmail
                        checkCmd.Parameters.AddWithValue("@Gemail", LoggedInGuardianEmail);
                        int count = (int)checkCmd.ExecuteScalar();

                        string query;
                        if (count > 0)
                        {
                            // UPDATE - FIXED: Removed trailing comma and added brackets around [Group]
                            query = @"UPDATE GUPDATETable SET
                                    GStartTime = @GStartTime,
                                    GEndTime = @GEndTime,
                                    YourArea = @YourArea,
                                    InsName = @InsName,
                                    Class = @Class,
                                    [Group] = @Group
                                    WHERE Gemail = @Gemail";
                        }
                        else
                        {
                            // INSERT - FIXED: Added brackets around [Group]
                            query = @"INSERT INTO GUPDATETable
                                    (GStartTime, GEndTime, YourArea, InsName, Class, [Group], Gemail)
                                    VALUES
                                    (@GStartTime, @GEndTime, @YourArea, @InsName, @Class, @Group, @Gemail)";
                        }

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@GStartTime", startTime);
                            cmd.Parameters.AddWithValue("@GEndTime", endTime);
                            cmd.Parameters.AddWithValue("@YourArea", YourArea);
                            cmd.Parameters.AddWithValue("@InsName", InsName);
                            cmd.Parameters.AddWithValue("@Class", Class);
                            cmd.Parameters.AddWithValue("@Group", Group);
                            cmd.Parameters.AddWithValue("@Gemail", LoggedInGuardianEmail);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Profile saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            OpenDashboard();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Empty event handlers kept to avoid 'missing reference' errors in Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void YourInfoG_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void AvailableArea_SelectedIndexChanged(object sender, EventArgs e) { }
        private void CGPA_TextChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void InstituitionName_TextChanged(object sender, EventArgs e) { }
        private void Group_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void nametextbox_TextChanged(object sender, EventArgs e) { }
        private void emailtextbox_TextChanged(object sender, EventArgs e) { }
        private void phonetextbox_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }

        // Helper Method to ensure Email is passed to the Dashboard
        private void OpenDashboard()
        {
            // PASS THE EMAIL TO THE DASHBOARD STATIC VARIABLE
            GuardianDashboard.LoggedInGuardianEmail = LoggedInGuardianEmail;

            GuardianDashboard Gdashboard = new GuardianDashboard();
            Gdashboard.Show();
            this.Close();
        }
    }
}