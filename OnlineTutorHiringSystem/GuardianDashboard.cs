using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineTutorHiringSystem
{
    public partial class GuardianDashboard : Form
    {
        public static string LoggedInGuardianEmail { get; set; }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";
        public GuardianDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void GuardianDashboard_Load(object sender, EventArgs e)
        {
            LoadTeacherData();
        }

        private void LoadTeacherData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Open the connection
                    con.Open();

                    // SQL Query to select from your specific table
                    string query = "SELECT TStartTime, TEndTime, ExSal, AvArea, InsName, Program, Semester, CGPA, Temail FROM TUPDATETable";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to your DataGridView
                        dataGridView1.DataSource = dt;

                        // 2. Rename columns to be user-friendly
                       
                       
                        dataGridView1.Columns["AvArea"].HeaderText = "Available Area";
                        dataGridView1.Columns["InsName"].HeaderText = "Institution";
                        dataGridView1.Columns["Program"].HeaderText = "Department";
                        dataGridView1.Columns["Semester"].HeaderText = "Semester";
                        dataGridView1.Columns["CGPA"].HeaderText = "CGPA";
                        dataGridView1.Columns["ExSal"].HeaderText = "Salary (BDT)";
                        dataGridView1.Columns["Temail"].HeaderText = "Contact Email";
                        dataGridView1.Columns["TStartTime"].HeaderText = "Start Time";
                        dataGridView1.Columns["TEndTime"].HeaderText = "End Time";

                        // 3. Make the grid Read-Only
                        dataGridView1.ReadOnly = true;

                        // 4. UI Enhancements (Optional but recommended)
                        dataGridView1.AllowUserToAddRows = false; // Removes the empty bottom row
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fits columns to window width
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selects whole row on click
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked a valid row (not the header)
            if (e.RowIndex >= 0)
            {
                // 1. Get the email from the selected row in the DataGridView
                // We use Temail because it's the common link between TUPDATETable and TTable
                string selectedEmail = dataGridView1.Rows[e.RowIndex].Cells["Temail"].Value.ToString();

                // 2. Fetch additional details (Name and Phone) from TTable
                FetchTeacherDetails(selectedEmail);
            }

        }

        private void FetchTeacherDetails(string email)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Query to find the Name and Number based on the Email
                    string query = "SELECT Tname, Tnumber, Temail FROM TTable WHERE Temail = @email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 3. Assign the values to your TextBoxes
                                TeacherNamebox.Text = reader["Tname"].ToString();
                                TeacherPhoneTextBox.Text = reader["Tnumber"].ToString();
                                TeacherEmailTextBox.Text = reader["Temail"].ToString();

                                TeacherNamebox.ReadOnly = true;
                                TeacherPhoneTextBox.ReadOnly = true;
                                TeacherEmailTextBox.ReadOnly = true;

                                // Optional: Change background color to indicate they are locked
                                TeacherNamebox.BackColor = SystemColors.ControlLight;
                                TeacherPhoneTextBox.BackColor = SystemColors.ControlLight;
                                TeacherEmailTextBox.BackColor = SystemColors.ControlLight;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching teacher details: " + ex.Message);
            }
        }

        private void TeacherNamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestTeacher_Click(object sender, EventArgs e)
        {
            string tEmail = TeacherEmailTextBox.Text.Trim();
            string gEmail = GuardianDashboard.LoggedInGuardianEmail;

            if (string.IsNullOrEmpty(tEmail) || string.IsNullOrEmpty(gEmail))
            {
                MessageBox.Show("Error: Please select a teacher and ensure you are logged in.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 1. SELF-HEALING: Create the table if it is missing
                    string createTableSql = @"
                IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HiringRequestTable]') AND type in (N'U'))
                BEGIN
                    CREATE TABLE [dbo].[HiringRequestTable] (
                        [RequestId] INT IDENTITY(1,1) PRIMARY KEY,
                        [TeacherEmail] NVARCHAR(100),
                        [GuardianEmail] NVARCHAR(100)
                    )
                END";

                    using (SqlCommand createCmd = new SqlCommand(createTableSql, con))
                    {
                        createCmd.ExecuteNonQuery();
                    }

                    // 2. DUPLICATE CHECK: See if this guardian already requested THIS teacher
                    string checkSql = "SELECT COUNT(*) FROM HiringRequestTable WHERE TeacherEmail = @t AND GuardianEmail = @g";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, con))
                    {
                        checkCmd.Parameters.AddWithValue("@t", tEmail);
                        checkCmd.Parameters.AddWithValue("@g", gEmail);

                        int existingRequests = (int)checkCmd.ExecuteScalar();

                        if (existingRequests > 0)
                        {
                            MessageBox.Show("You have already sent a hiring request to this teacher. Please wait for their response.");
                            return; // Stop the code here so no new insert happens
                        }
                    }

                    // 2. NOW perform the Insert
                    string sql = "INSERT INTO HiringRequestTable (TeacherEmail, GuardianEmail) VALUES (@t, @g)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@t", tEmail);
                        cmd.Parameters.AddWithValue("@g", gEmail);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Success! Request sent to " + tEmail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Login logg = new Login();

            logg.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Guardian g = new Guardian();
            g.Show();
            this.Hide();
        }
    }
 }

