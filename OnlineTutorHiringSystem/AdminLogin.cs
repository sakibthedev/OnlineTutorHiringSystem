using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Required for database connection

namespace OnlineTutorHiringSystem
{
    public partial class AdminLogin : Form
    {
        // UPDATED: Added Encrypt=False and TrustServerCertificate=True to resolve connection issues
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            // FIXED: Hides password characters as you type
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // 1. Validation: Check if fields are empty
            if (string.IsNullOrWhiteSpace(EmailTextBox1.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter both Email and Password.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Logic for Default Admin Credential
                string defaultEmail = "sakib@mytutor.com.bd";
                string defaultPass = "sakib1234";

                if (EmailTextBox1.Text == defaultEmail && PasswordTextBox.Text == defaultPass)
                {
                    ProceedToDashboard();
                    return;
                }

                // 3. Database Validation (Check the 'Admins' table)
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // FIXED: Changed 'Password' to 'PasswordHash' to match your database schema
                    string query = "SELECT COUNT(*) FROM Admins WHERE Email = @email AND PasswordHash = @pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", EmailTextBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text.Trim());

                        int userExists = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userExists > 0)
                        {
                            ProceedToDashboard();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            PasswordTextBox.Clear();
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Displays specific database errors
                MessageBox.Show("Database Connection Error: " + sqlEx.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handles any other unexpected errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to handle navigation
        private void ProceedToDashboard()
        {
            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}