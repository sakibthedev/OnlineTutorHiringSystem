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
    public partial class TeacherDashboard : Form
    {
        // This must match the assignment in your Login form
        public static string LoggedInTeacherEmail { get; set; }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

        public TeacherDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBackToProfile_Click(object sender, EventArgs e)
        {
            // Pass the email back to the Teacher profile form
            OnlineTutorHiringSystem.Teacher.LoggedInTeacherEmail = LoggedInTeacherEmail;

            OnlineTutorHiringSystem.Teacher tProfile = new OnlineTutorHiringSystem.Teacher();
            tProfile.Show();
            this.Close();
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            LoadIncomingRequests();
        }

        private void LoadIncomingRequests()
        {
            string currentTeacherEmail = TeacherDashboard.LoggedInTeacherEmail;

            // Debug check to ensure the email was passed from the Login form
            if (string.IsNullOrEmpty(currentTeacherEmail))
            {
                MessageBox.Show("Debug: Teacher Email is empty! Check your Login form assignment.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // FIXED: Removed the extra quotes and semicolon that caused the "Unclosed quotation mark" error
                    // FIXED: Added GStartTime and GEndTime to the SELECT so they can be displayed
                    string query = @" 
                        SELECT B.Gname, B.Gnumber, R.GuardianEmail, G.YourArea, G.InsName, G.Class, G.[Group], G.GStartTime, G.GEndTime
                        FROM HiringRequestTable R
                        INNER JOIN GTable B ON R.GuardianEmail = B.Gemail
                        LEFT JOIN GUPDATETable G ON R.GuardianEmail = G.Gemail
                        WHERE R.TeacherEmail = @tEmail";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@tEmail", currentTeacherEmail.Trim());
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewRequestsForTeacher.DataSource = dt;

                        dataGridViewRequestsForTeacher.ReadOnly = true;
                        // Prevents the user from adding new rows manually
                        dataGridViewRequestsForTeacher.AllowUserToAddRows = false;

                        // Prevents the user from deleting rows with the 'Delete' key
                        dataGridViewRequestsForTeacher.AllowUserToDeleteRows = false;

                        // Automatically resize columns to fit the content
                        dataGridViewRequestsForTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Make the rows easier to read with alternating colors
                        dataGridViewRequestsForTeacher.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                        // Check if columns exist before renaming to avoid errors
                        if (dataGridViewRequestsForTeacher.Columns.Count > 0)
                        {
                            if (dt.Columns.Contains("Gname")) dataGridViewRequestsForTeacher.Columns["Gname"].HeaderText = "Guardian Name";
                            if (dt.Columns.Contains("Gnumber")) dataGridViewRequestsForTeacher.Columns["Gnumber"].HeaderText = "Contact No";
                            if (dt.Columns.Contains("GuardianEmail")) dataGridViewRequestsForTeacher.Columns["GuardianEmail"].HeaderText = "Email";
                            if (dt.Columns.Contains("YourArea")) dataGridViewRequestsForTeacher.Columns["YourArea"].HeaderText = "Area";
                            if (dt.Columns.Contains("InsName")) dataGridViewRequestsForTeacher.Columns["InsName"].HeaderText = "Institution";
                            if (dt.Columns.Contains("GStartTime")) dataGridViewRequestsForTeacher.Columns["GStartTime"].HeaderText = "Start Time";
                            if (dt.Columns.Contains("GEndTime")) dataGridViewRequestsForTeacher.Columns["GEndTime"].HeaderText = "End Time";
                        }

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No hire requests found for " + currentTeacherEmail);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // This catches SQL syntax errors like the keyword 'Group' or unclosed quotes
                MessageBox.Show("Error loading requests: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle clicking on a specific request
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Show();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Close();
        }
    }
}