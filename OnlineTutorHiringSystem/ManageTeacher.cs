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
    public partial class ManageTeacher : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

        public ManageTeacher()
        {
            InitializeComponent();
        }

        private void ManageTeacher_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Make sure panels start hidden
            editPanel.Visible = false;
            panel1.Visible = false;
            LoadTeacherData();
        }

        private void LoadTeacherData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            T.Tname AS [Name], 
                            T.Temail AS [Email], 
                            T.Tnumber AS [Phone], 
                            T.Tpassword AS [Password],
                            U.InsName AS [Institution], 
                            U.Program, 
                            U.Semester, 
                            U.CGPA, 
                            U.TStartTime AS [Start Time], 
                            U.TEndTime AS [End Time], 
                            U.ExSal AS [Salary], 
                            U.AvArea AS [Area]
                        FROM TTable T
                        LEFT JOIN TUPDATETable U ON T.Temail = U.Temail";

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

        // --- ADD TEACHER BUTTON (Main Form): SHOWS THE PANEL ---
        private void addTeacher_Click(object sender, EventArgs e)
        {
            // Reset textboxes for fresh entry
            textBox17.Clear(); textBox16.Clear(); textBox15.Clear();
            textBox14.Clear(); textBox13.Clear(); textBox12.Clear();
            textBox11.Clear(); textBox10.Clear(); textBox9.Clear();
            textBox8.Clear();

            // Force visibility
            editPanel.Visible = false;
            panel1.Visible = true;

            // This is critical: ensures panel isn't hiding behind the grid
            panel1.BringToFront();

            // Optional: Move panel to a specific location if it's misplaced
            panel1.Location = new Point((this.ClientSize.Width - panel1.Width) / 2, (this.ClientSize.Height - panel1.Height) / 2);
        }

        // --- BUTTON 2 (Inside panel1): SAVE NEW TEACHER TO DATABASE ---
        private void button2_Click(object sender, EventArgs e)
        {
            float addCgpa;
            string cgpaInput = textBox11.Text.Trim();

            if (string.IsNullOrEmpty(cgpaInput) || !float.TryParse(cgpaInput, out addCgpa) || addCgpa < 0.00f || addCgpa > 4.00f)
            {
                MessageBox.Show("Invalid CGPA. Range: 0.00 - 4.00", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBox16.Text))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        try
                        {
                            string insertT = "INSERT INTO TTable (Tname, Temail, Tnumber, Tpassword) VALUES (@name, @email, @phone, @pass)";
                            SqlCommand cmd1 = new SqlCommand(insertT, con, trans);
                            cmd1.Parameters.AddWithValue("@name", textBox17.Text.Trim());
                            cmd1.Parameters.AddWithValue("@email", textBox16.Text.Trim());
                            cmd1.Parameters.AddWithValue("@phone", textBox15.Text.Trim());
                            cmd1.Parameters.AddWithValue("@pass", textBox9.Text.Trim());
                            cmd1.ExecuteNonQuery();

                            string insertU = "INSERT INTO TUPDATETable (Temail, InsName, Semester, Program, CGPA, ExSal, TStartTime, TEndTime, AvArea) " +
                                             "VALUES (@email, @ins, @sem, @prog, @cgpa, @sal, @start, @end, @area)";
                            SqlCommand cmd2 = new SqlCommand(insertU, con, trans);
                            cmd2.Parameters.AddWithValue("@email", textBox16.Text.Trim());
                            cmd2.Parameters.AddWithValue("@ins", textBox14.Text.Trim());
                            cmd2.Parameters.AddWithValue("@sem", textBox13.Text.Trim());
                            cmd2.Parameters.AddWithValue("@prog", textBox12.Text.Trim());
                            cmd2.Parameters.AddWithValue("@cgpa", addCgpa);
                            cmd2.Parameters.AddWithValue("@sal", textBox10.Text.Trim());
                            cmd2.Parameters.AddWithValue("@start", kryptonDateTimePicker2.Value.ToString("hh:mm tt"));
                            cmd2.Parameters.AddWithValue("@end", kryptonDateTimePicker1.Value.ToString("hh:mm tt"));
                            cmd2.Parameters.AddWithValue("@area", textBox8.Text.Trim());
                            cmd2.ExecuteNonQuery();

                            trans.Commit();
                            MessageBox.Show("New Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            panel1.Visible = false;
                            LoadTeacherData();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Error during insertion: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Failed: " + ex.Message);
            }
        }

        // --- BUTTON 1 (Inside panel1): CANCEL ADDING ---
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        // --- EDIT LOGIC ---
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                textBox1.Text = row.Cells["Name"].Value?.ToString();
                textBox2.Text = row.Cells["Email"].Value?.ToString();
                textBox3.Text = row.Cells["Phone"].Value?.ToString();
                textBox4.Text = row.Cells["Institution"].Value?.ToString();
                textBox5.Text = row.Cells["Semester"].Value?.ToString();
                textBox6.Text = row.Cells["Program"].Value?.ToString();
                textBox7.Text = row.Cells["CGPA"].Value?.ToString();
                passEditT.Text = row.Cells["Password"].Value?.ToString();
                exedit.Text = row.Cells["Salary"].Value?.ToString();
                areaTextbox.Text = row.Cells["Area"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["Start Time"].Value?.ToString(), out DateTime sTime)) StartTime.Value = sTime;
                if (DateTime.TryParse(row.Cells["End Time"].Value?.ToString(), out DateTime eTime)) EndTime.Value = eTime;

                textBox2.ReadOnly = true;
                panel1.Visible = false;
                editPanel.Visible = true;
                editPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a teacher from the list to edit.");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            float cgpaValue;
            if (!float.TryParse(textBox7.Text.Trim(), out cgpaValue) || cgpaValue < 0 || cgpaValue > 4)
            {
                MessageBox.Show("Invalid CGPA.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        try
                        {
                            // Update TTable
                            string updateT = "UPDATE TTable SET Tname=@name, Tnumber=@phone, Tpassword=@pass WHERE Temail=@email";
                            SqlCommand cmd1 = new SqlCommand(updateT, con, trans);
                            cmd1.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                            cmd1.Parameters.AddWithValue("@phone", textBox3.Text.Trim());
                            cmd1.Parameters.AddWithValue("@pass", passEditT.Text.Trim());
                            cmd1.Parameters.AddWithValue("@email", textBox2.Text.Trim());
                            cmd1.ExecuteNonQuery();

                            // Update TUPDATETable
                            string updateU = "UPDATE TUPDATETable SET InsName=@ins, Semester=@sem, Program=@prog, CGPA=@cgpa, ExSal=@sal, TStartTime=@start, TEndTime=@end, AvArea=@area WHERE Temail=@email";
                            SqlCommand cmd2 = new SqlCommand(updateU, con, trans);
                            cmd2.Parameters.AddWithValue("@ins", textBox4.Text.Trim());
                            cmd2.Parameters.AddWithValue("@sem", textBox5.Text.Trim());
                            cmd2.Parameters.AddWithValue("@prog", textBox6.Text.Trim());
                            cmd2.Parameters.AddWithValue("@cgpa", cgpaValue);
                            cmd2.Parameters.AddWithValue("@sal", exedit.Text.Trim());
                            cmd2.Parameters.AddWithValue("@start", StartTime.Value.ToString("hh:mm tt"));
                            cmd2.Parameters.AddWithValue("@end", EndTime.Value.ToString("hh:mm tt"));
                            cmd2.Parameters.AddWithValue("@area", areaTextbox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@email", textBox2.Text.Trim());
                            cmd2.ExecuteNonQuery();

                            trans.Commit();
                            MessageBox.Show("Teacher updated successfully!");
                            editPanel.Visible = false;
                            LoadTeacherData();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Update failed: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string email = dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();
                if (MessageBox.Show($"Are you sure you want to delete teacher: {email}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            using (SqlTransaction trans = con.BeginTransaction())
                            {
                                try
                                {
                                    new SqlCommand($"DELETE FROM TUPDATETable WHERE Temail = '{email}'", con, trans).ExecuteNonQuery();
                                    new SqlCommand($"DELETE FROM TTable WHERE Temail = '{email}'", con, trans).ExecuteNonQuery();
                                    trans.Commit();
                                    LoadTeacherData();
                                }
                                catch { trans.Rollback(); throw; }
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Delete failed: " + ex.Message); }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) { editPanel.Visible = false; }

        private void backbutton_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        // --- EMPTY HANDLERS: DO NOT REMOVE (Essential for Designer) ---
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void editPanel_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void exedit_TextChanged(object sender, EventArgs e) { }
        private void passEditT_TextChanged(object sender, EventArgs e) { }
        private void StartTime_ValueChanged(object sender, EventArgs e) { }
        private void EndTime_ValueChanged(object sender, EventArgs e) { }
        private void areaTextbox_TextChanged(object sender, EventArgs e) { }
        private void textBox17_TextChanged(object sender, EventArgs e) { }
        private void textBox16_TextChanged(object sender, EventArgs e) { }
        private void textBox15_TextChanged(object sender, EventArgs e) { }
        private void textBox14_TextChanged(object sender, EventArgs e) { }
        private void textBox13_TextChanged(object sender, EventArgs e) { }
        private void textBox12_TextChanged(object sender, EventArgs e) { }
        private void textBox11_TextChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void kryptonDateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}