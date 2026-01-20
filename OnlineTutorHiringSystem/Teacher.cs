using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineTutorHiringSystem
{
    public partial class Teacher : Form
    {
        // Logged-in teacher email (set from Login form)
        public static string LoggedInTeacherEmail;

        public Teacher()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // Lock textboxes
            textBox1.ReadOnly = true; // Name
            textBox2.ReadOnly = true; // Email
            textBox3.ReadOnly = true; // Number / ID

            // Load teacher data from DB
            LoadTeacherInfo();

            // Populate ComboBox with areas
            AvailableArea.Items.Clear();
            AvailableArea.Items.Add("Select Area");
            AvailableArea.Items.Add("Dhanmondi");
            AvailableArea.Items.Add("Banani");
            AvailableArea.Items.Add("Gulshan");
            AvailableArea.Items.Add("Farmgate");
            AvailableArea.Items.Add("Uttara");
            AvailableArea.Items.Add("Bashundhara");
            AvailableArea.Items.Add("Mohakhali");

            AvailableArea.SelectedIndex = 0; // default selection
        }

        private void LoadTeacherInfo()
        {
            if (string.IsNullOrEmpty(LoggedInTeacherEmail))
            {
                MessageBox.Show(
                    "No teacher session found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

            string query =
                "SELECT Tnumber, Tname, Temail FROM TTable WHERE Temail = @Temail";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Temail", LoggedInTeacherEmail);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox1.Text = reader["Tname"].ToString();   // Name
                    textBox2.Text = reader["Temail"].ToString();  // Email
                    textBox3.Text = reader["Tnumber"].ToString(); // Number / ID
                }
                else
                {
                    MessageBox.Show(
                        "Teacher data not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                reader.Close();
            }
        }

        // ---- ComboBox selection changed ----
        private void AvailableArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: you can use this to react to area selection
            // Example:
            // string selectedArea = comboBox1.SelectedItem.ToString();
        }

        // ---- Auto-generated empty handlers (UNCHANGED) ----
        private void feetlbl_TextChanged(object sender, EventArgs e) { }
        private void label30_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void enddtp_ValueChanged(object sender, EventArgs e)
        {
            // Optional: put code here if you want to do something when date changes
        }
        private void startdtp_ValueChanged(object sender, EventArgs e)
        {
            // Optional: put code here if you want to do something when date changes
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ProgramName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Semester_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ExpectedSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstituitionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_click_Click(object sender, EventArgs e)
        {
            
        
            if (string.IsNullOrEmpty(LoggedInTeacherEmail))
            {
                MessageBox.Show("No teacher session found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Collect and convert values
            string institution = InstituitionName.Text.Trim();
            string program = ProgramName.Text.Trim();
            string semester = Semester.Text.Trim();
            string area = AvailableArea.SelectedItem?.ToString();

            DateTime startTime = startdtp.Value;
            DateTime endTime = enddtp.Value;

            // Convert numeric values
            if (!decimal.TryParse(CGPA.Text.Trim(), out decimal cgpaValue))
            {
                MessageBox.Show("Enter a valid number for CGPA.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cgpaValue < 0.00m || cgpaValue > 4.00m)
            {
                MessageBox.Show("CGPA must be between 0.00 and 4.00.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(ExpectedSalary.Text.Trim(), out decimal exSalValue))
            {
                MessageBox.Show("Enter a valid number for Expected Salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(institution) || string.IsNullOrEmpty(program) ||
                string.IsNullOrEmpty(semester) || string.IsNullOrEmpty(area) || area == "Select Area")
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
                    string checkQuery = "SELECT COUNT(*) FROM TUPDATETable WHERE Temail = @Temail";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Temail", LoggedInTeacherEmail);
                        int count = (int)checkCmd.ExecuteScalar();

                        string query;
                        if (count > 0)
                        {
                            // UPDATE
                            query = @"UPDATE TUPDATETable SET
                                TStartTime = @TStartTime,
                                TEndTime = @TEndTime,
                                ExSal = @ExSal,
                                AvArea = @AvArea,
                                InsName = @InsName,
                                Program = @Program,
                                Semester = @Semester,
                                CGPA = @CGPA
                              WHERE Temail = @Temail";
                        }
                        else
                        {
                            // INSERT
                            query = @"INSERT INTO TUPDATETable
                                (TStartTime, TEndTime, ExSal, AvArea, InsName, Program, Semester, CGPA, Temail)
                              VALUES
                                (@TStartTime, @TEndTime, @ExSal, @AvArea, @InsName, @Program, @Semester, @CGPA, @Temail)";
                        }

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Add parameters with correct types
                            cmd.Parameters.AddWithValue("@TStartTime", startTime);
                            cmd.Parameters.AddWithValue("@TEndTime", endTime);
                            cmd.Parameters.AddWithValue("@ExSal", exSalValue);      // decimal/number
                            cmd.Parameters.AddWithValue("@AvArea", area);
                            cmd.Parameters.AddWithValue("@InsName", institution);
                            cmd.Parameters.AddWithValue("@Program", program);
                            cmd.Parameters.AddWithValue("@Semester", semester);
                            cmd.Parameters.AddWithValue("@CGPA", cgpaValue);        // decimal/number
                            cmd.Parameters.AddWithValue("@Temail", LoggedInTeacherEmail);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Profile saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            
                            TeacherDashboard.LoggedInTeacherEmail = LoggedInTeacherEmail;

                            TeacherDashboard dashboard = new TeacherDashboard();
                            dashboard.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Skip_Click(object sender, EventArgs e)
        {
            // FIX: Ensure the email follows the user even if they skip updating
            TeacherDashboard.LoggedInTeacherEmail = LoggedInTeacherEmail;

            TeacherDashboard tdash = new TeacherDashboard();
            tdash.Show();
            this.Close();
        }

        private void Hello_Click(object sender, EventArgs e)
        {

        }
    }
}

