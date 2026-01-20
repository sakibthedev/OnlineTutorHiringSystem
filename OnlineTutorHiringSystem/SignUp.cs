using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace OnlineTutorHiringSystem
{
    public partial class close : KryptonForm
    {
        public close()
        {
            InitializeComponent();
        }

        private void close_Load(object sender, EventArgs e)
        {
            name.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sup_Click(object sender, EventArgs e)
        {
            String Name = name.Text;
            String Email = email.Text;
            String Password = password.Text;
            String Phone = number.Text;
            string ConfirmPassword = cpassword.Text;

            if (Name == "" || Name == "Your Name" || Name == "Name" || Name == "Your")
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.Focus();
                return;
            }

            if (Phone == "" || Phone == "Phone Number" || Phone.Length != 11 || Phone.Any(char.IsLetter) == true || !Phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter your valid Bangladeshi 11-digit phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                number.Focus();
                return;
            }

            if (Email == "" || Email == "Email" || Email.Contains("@") == false || Email.EndsWith(".com") == false ||
                Email.Contains(".") == false || Email.Any(char.IsUpper) == true)
            {
                MessageBox.Show("Please enter your valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Focus();
                return;
            }

            if (Password == "" || Password == "Password")
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Focus();
                return;
            }

            if (Password.Length <= 8 || Password.Any(char.IsLower) == false || Password.Any(char.IsUpper) == false)
            {
                MessageBox.Show("Password must be at least 8 characters and contain uppercase, lowercase.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                password.Focus();
                return;
            }

            if (Password.Length >= 10)
            {
                MessageBox.Show("Password must be less than 10 characters long.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Focus();
                return;
            }

            if (ConfirmPassword == "" || ConfirmPassword == "Confirm Password" || ConfirmPassword != Password)
            {
                MessageBox.Show("Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cpassword.Focus();
                return;
            }

            if (!Guardian.Checked && !Teacher.Checked)
            {
                MessageBox.Show("Please select a role (Guardian or Teacher).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Database Email Match Check Start ---
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

            using (SqlConnection checkConn = new SqlConnection(connectionString))
            {
                checkConn.Open();
               
                string checkQuery = "SELECT COUNT(*) FROM GTable WHERE Gemail = @email UNION ALL SELECT COUNT(*) FROM TTable WHERE Temail = @email";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, checkConn))
                {
                    checkCmd.Parameters.AddWithValue("@email", Email.Trim());
                    int count = 0;
                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count += (int)reader[0];
                        }
                    }

                    if (count > 0)
                    {
                        MessageBox.Show("This email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        email.Focus();
                        return; 
                    }
                }
            }
           

            if (Guardian.Checked == true)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand q1 = new SqlCommand(
                        "INSERT INTO GTable (Gnumber, Gname, Gemail, Gpassword) " +
                        "VALUES (@Gnumber, @Gname, @Gemail, @Gpassword)", connection);

                    q1.Parameters.AddWithValue("@Gnumber", number.Text.Trim());
                    q1.Parameters.AddWithValue("@Gname", name.Text.Trim());
                    q1.Parameters.AddWithValue("@Gemail", email.Text.Trim());
                    q1.Parameters.AddWithValue("@Gpassword", password.Text);

                    q1.ExecuteNonQuery();
                }

                MessageBox.Show("You have successfully signed up as a Guardian", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Teacher.Checked == true)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand q2 = new SqlCommand(
                        "INSERT INTO TTable (Tnumber, Tname, Temail, Tpassword) " +
                        "VALUES (@Tnumber, @Tname, @Temail, @Tpassword)", connection);

                    q2.Parameters.AddWithValue("@Tnumber", number.Text.Trim());
                    q2.Parameters.AddWithValue("@Tname", name.Text.Trim());
                    q2.Parameters.AddWithValue("@Temail", email.Text.Trim());
                    q2.Parameters.AddWithValue("@Tpassword", password.Text);

                    q2.ExecuteNonQuery();
                }

                MessageBox.Show("You have successfully signed up as a Teacher.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Login login = new Login();
            login.Visible = true;
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Hide();
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Your Name" || name.Text == "Name" || name.Text == "Your")
            {
                name.Text = "";
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Your Name";
            }
        }

        private void number_Enter(object sender, EventArgs e)
        {
            if (number.Text == "Phone Number")
            {
                number.Text = "";
            }
        }

        private void number_Leave(object sender, EventArgs e)
        {
            if (number.Text == "")
            {
                number.Text = "Phone Number";
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.PasswordChar = showPass.Checked ? '\0' : '*';
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.PasswordChar = '\0';
            }
        }

        private void cpassword_Enter(object sender, EventArgs e)
        {
            if (cpassword.Text == "Confirm Password")
            {
                cpassword.Text = "";
                cpassword.PasswordChar = showPass.Checked ? '\0' : '*';
            }
        }

        private void cpassword_Leave(object sender, EventArgs e)
        {
            if (cpassword.Text == "")
            {
                cpassword.Text = "Confirm Password";
                cpassword.PasswordChar = '\0';
            }
        }

        private void close_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (password.Text != "Password")
                password.PasswordChar = showPass.Checked ? '\0' : '*';

            if (cpassword.Text != "Confirm Password")
                cpassword.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}