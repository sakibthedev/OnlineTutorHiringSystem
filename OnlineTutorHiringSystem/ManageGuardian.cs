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
    public partial class ManageGuardian : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

        public ManageGuardian()
        {
            InitializeComponent();
        }

        private void ManageGuardian_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            panel1.Visible = false;
            addG.Visible = false;

            LoadGuardianData();
        }

        private void LoadGuardianData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            G.Gname AS [Guardian Name], 
                            G.Gnumber AS [Phone Number], 
                            G.Gemail AS [Email Address], 
                            G.Gpassword AS [Password],
                            U.YourArea AS [Area], 
                            U.InsName AS [Institute],
                            U.Class, 
                            U.[Group],
                            U.GStartTime AS [Start Time], 
                            U.GEndTime AS [End Time] 
                        FROM GTable G
                        LEFT JOIN GUPDATETable U ON G.Gemail = U.Gemail";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string emailToDelete = dataGridView1.SelectedRows[0].Cells["Email Address"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete guardian: {emailToDelete}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
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
                                    string deleteQuery2 = "DELETE FROM GUPDATETable WHERE Gemail = @email";
                                    SqlCommand cmd2 = new SqlCommand(deleteQuery2, con, trans);
                                    cmd2.Parameters.AddWithValue("@email", emailToDelete);
                                    cmd2.ExecuteNonQuery();

                                    string deleteQuery1 = "DELETE FROM GTable WHERE Gemail = @email";
                                    SqlCommand cmd1 = new SqlCommand(deleteQuery1, con, trans);
                                    cmd1.Parameters.AddWithValue("@email", emailToDelete);
                                    cmd1.ExecuteNonQuery();

                                    trans.Commit();
                                    MessageBox.Show("Guardian record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadGuardianData();
                                }
                                catch (Exception ex)
                                {
                                    trans.Rollback();
                                    throw ex;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Load basic info
                textBox1.Text = row.Cells["Guardian Name"].Value?.ToString();
                textBox2.Text = row.Cells["Email Address"].Value?.ToString();
                textBox3.Text = row.Cells["Phone Number"].Value?.ToString();

                // Load Password into passwordEditG
                passwordEditG.Text = row.Cells["Password"].Value?.ToString();

                // Load Update Table info
                textBox4.Text = row.Cells["Institute"].Value?.ToString();
                ClassCombo.Text = row.Cells["Class"].Value?.ToString();
                GroupCombo.Text = row.Cells["Group"].Value?.ToString();
                comboBox4.Text = row.Cells["Area"].Value?.ToString();
                kryptonDateTimePicker3.Text = row.Cells["Start Time"].Value?.ToString();
                kryptonDateTimePicker2.Text = row.Cells["End Time"].Value?.ToString();

                addG.Visible = false;
                panel1.Visible = true;
                panel1.BringToFront();
                textBox2.ReadOnly = true; // Email is key, should not be changed
            }
            else
            {
                MessageBox.Show("Please select a row first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
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
                            // Update GTable including the Password from passwordEditG
                            string query1 = "UPDATE GTable SET Gname = @name, Gnumber = @phone, Gpassword = @pass WHERE Gemail = @email";
                            SqlCommand cmd1 = new SqlCommand(query1, con, trans);
                            cmd1.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                            cmd1.Parameters.AddWithValue("@phone", textBox3.Text.Trim());
                            cmd1.Parameters.AddWithValue("@pass", passwordEditG.Text.Trim());
                            cmd1.Parameters.AddWithValue("@email", textBox2.Text.Trim());
                            cmd1.ExecuteNonQuery();

                            // Update GUPDATETable
                            string query2 = "UPDATE GUPDATETable SET Class = @class, [Group] = @group, InsName = @ins, YourArea = @area, GStartTime = @start, GEndTime = @end WHERE Gemail = @email";
                            SqlCommand cmd2 = new SqlCommand(query2, con, trans);
                            cmd2.Parameters.AddWithValue("@class", ClassCombo.Text);
                            cmd2.Parameters.AddWithValue("@group", GroupCombo.Text);
                            cmd2.Parameters.AddWithValue("@ins", textBox4.Text.Trim());
                            cmd2.Parameters.AddWithValue("@area", comboBox4.Text);
                            cmd2.Parameters.AddWithValue("@start", kryptonDateTimePicker3.Text);
                            cmd2.Parameters.AddWithValue("@end", kryptonDateTimePicker2.Text);
                            cmd2.Parameters.AddWithValue("@email", textBox2.Text.Trim());
                            cmd2.ExecuteNonQuery();

                            trans.Commit();
                            MessageBox.Show("Guardian updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panel1.Visible = false;
                            LoadGuardianData();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            textBox8.Clear(); textBox7.Clear(); textBox6.Clear(); textBox5.Clear();
            passwordManageG.Clear();
            comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;

            panel1.Visible = false;
            addG.Visible = true;
            addG.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(passwordManageG.Text))
            {
                MessageBox.Show("Name, Email, and Password are mandatory!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            string q1 = "INSERT INTO GTable (Gname, Gemail, Gnumber, Gpassword) VALUES (@name, @email, @phone, @pass)";
                            SqlCommand cmd1 = new SqlCommand(q1, con, trans);
                            cmd1.Parameters.AddWithValue("@name", textBox8.Text.Trim());
                            cmd1.Parameters.AddWithValue("@email", textBox7.Text.Trim());
                            cmd1.Parameters.AddWithValue("@phone", textBox6.Text.Trim());
                            cmd1.Parameters.AddWithValue("@pass", passwordManageG.Text.Trim());
                            cmd1.ExecuteNonQuery();

                            string q2 = "INSERT INTO GUPDATETable (Gemail, InsName, Class, [Group], YourArea, GStartTime, GEndTime) VALUES (@email, @ins, @class, @group, @area, @start, @end)";
                            SqlCommand cmd2 = new SqlCommand(q2, con, trans);
                            cmd2.Parameters.AddWithValue("@email", textBox7.Text.Trim());
                            cmd2.Parameters.AddWithValue("@ins", textBox5.Text.Trim());
                            cmd2.Parameters.AddWithValue("@class", comboBox2.Text);
                            cmd2.Parameters.AddWithValue("@group", comboBox1.Text);
                            cmd2.Parameters.AddWithValue("@area", comboBox3.Text);
                            cmd2.Parameters.AddWithValue("@start", startdtp.Text);
                            cmd2.Parameters.AddWithValue("@end", kryptonDateTimePicker1.Text);
                            cmd2.ExecuteNonQuery();

                            trans.Commit();
                            MessageBox.Show("Guardian added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            addG.Visible = false;
                            LoadGuardianData();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Error: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addG.Visible = false;
        }

        // --- Placeholders kept to prevent Designer issues ---
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void mGemail_Click(object sender, EventArgs e) { }
        private void mGgroup_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void ClassCombo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void GroupCombo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void addG_Paint(object sender, PaintEventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AddGuardian_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void startdtp_ValueChanged(object sender, EventArgs e) { }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void kryptonDateTimePicker3_ValueChanged(object sender, EventArgs e) { }
        private void kryptonDateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void passwordManageG_TextChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void passwordEditG_TextChanged(object sender, EventArgs e) { }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
    }
}