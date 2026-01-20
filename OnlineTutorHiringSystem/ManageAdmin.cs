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
    public partial class ManageAdmin : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

        public ManageAdmin()
        {
            InitializeComponent();
        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            editPanel.Visible = false;
            AddPanel.Visible = false;
            LoadAdminData();
        }

        private void LoadAdminData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT FullName, Email, PhoneNumber, PasswordHash FROM Admins";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- VALIDATION HELPER METHODS ---

        private bool IsValidPassword(string password)
        {
            // Rule: Minimum 8 characters AND must contain at least one number
            return password.Length >= 8 && password.Any(char.IsDigit);
        }

        private bool IsDuplicatePhone(string phone, string currentEmail = "")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // If updating, we exclude the current admin's email from the check
                string query = "SELECT COUNT(*) FROM Admins WHERE PhoneNumber = @phone AND Email != @currentEmail";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@currentEmail", currentEmail);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // --- BUTTON CLICKS ---

        private void AddButton_Click(object sender, EventArgs e)
        {
            textBox8.Clear(); textBox7.Clear(); textBox6.Clear(); textBox5.Clear();
            editPanel.Visible = false;
            AddPanel.Visible = true;
            AddPanel.BringToFront();
        }

        // SAVE Button inside AddPanel (INSERT)
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox8.Text.Trim();
            string email = textBox7.Text.Trim();
            string phone = textBox6.Text.Trim();
            string pass = textBox5.Text.Trim();

            // 1. Password Validation
            if (!IsValidPassword(pass))
            {
                MessageBox.Show("Password must be at least 8 characters long and include at least one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Duplicate Phone Check
            if (IsDuplicatePhone(phone))
            {
                MessageBox.Show("This phone number is already registered to another admin.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Admins (FullName, Email, PhoneNumber, PasswordHash) VALUES (@name, @email, @phone, @pass)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddPanel.Visible = false;
                    LoadAdminData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Add Failed: " + ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e) => AddPanel.Visible = false;

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                textBox1.Text = row.Cells["FullName"].Value?.ToString() ?? row.Cells[0].Value?.ToString();
                textBox2.Text = row.Cells["Email"].Value?.ToString() ?? row.Cells[1].Value?.ToString();
                textBox3.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? row.Cells[2].Value?.ToString();
                textBox4.Text = row.Cells["PasswordHash"].Value?.ToString() ?? row.Cells[3].Value?.ToString();

                textBox2.ReadOnly = true;
                AddPanel.Visible = false;
                editPanel.Visible = true;
                editPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        // SAVE Button inside EditPanel (UPDATE)
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string pass = textBox4.Text.Trim();

            // 1. Password Validation
            if (!IsValidPassword(pass))
            {
                MessageBox.Show("Password must be at least 8 characters long and include at least one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Duplicate Phone Check (passing current email to ignore itself)
            if (IsDuplicatePhone(phone, email))
            {
                MessageBox.Show("This phone number is already in use by another admin.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Admins SET FullName = @name, PhoneNumber = @phone, PasswordHash = @pass WHERE Email = @email";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@email", email);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully!");
                    editPanel.Visible = false;
                    LoadAdminData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Update Failed: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => editPanel.Visible = false;

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string email = dataGridView1.SelectedRows[0].Cells["Email"].Value?.ToString() ?? dataGridView1.SelectedRows[0].Cells[1].Value?.ToString();
                if (MessageBox.Show($"Delete admin {email}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM Admins WHERE Email = @email", con);
                            cmd.Parameters.AddWithValue("@email", email);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            LoadAdminData();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Delete Failed: " + ex.Message); }
                }
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        // Designer Events
        private void CancelButton_Click(object sender, EventArgs e) { btnCancel_Click(sender, e); }
        private void EditButton_Click_1(object sender, EventArgs e) { EditButton_Click(sender, e); }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void editPanel_Paint(object sender, PaintEventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void AddPanel_Paint(object sender, PaintEventArgs e) { }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}