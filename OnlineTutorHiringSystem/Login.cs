using ComponentFactory.Krypton.Toolkit;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineTutorHiringSystem
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sup_Click(object sender, EventArgs e)
        {
            string enteredPassword = password.Text;
            string enteredEmail = emailText.Text;

           

            if (enteredEmail == "Email" || enteredEmail == "")
            {
                MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailText.Focus();
                return;
            }

            if (enteredPassword == "Password" || enteredPassword == "")
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Focus();
                return;
            }

            if (enteredPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Focus();
                return;
            }

            if (enteredPassword.Any(char.IsLower) == false || enteredPassword.Any(char.IsUpper) == false)
            {
                MessageBox.Show("Password must contain both uppercase and lowercase letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Focus();
                return;
            }

            if (Guardian.Checked == false && Teacher.Checked == false)
            {
                MessageBox.Show("Please select a role (Guardian or Teacher).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Guardian.Checked == true)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM GTable WHERE Gemail = @Email AND Gpassword = @Password";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@Email", emailText.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", password.Text.Trim());

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                                
                                
                                    
                                    OnlineTutorHiringSystem.Guardian.LoggedInGuardianEmail = emailText.Text.Trim();

                                    
                                    OnlineTutorHiringSystem.Guardian g = new OnlineTutorHiringSystem.Guardian();
                                    g.Show();
                                    this.Hide();
                                


                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                emailText.Focus();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (Teacher.Checked == true)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\OneDrive\Desktop\AIUB 7th Semester\OOP2\TEST\TestProject\TestProject\OnlineTutorHiringSystem\OnlineTutorHiringSystem\SignUp.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM TTable WHERE Temail = @Email AND Tpassword = @Password";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            
                            cmd.Parameters.AddWithValue("@Email", emailText.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", password.Text.Trim());

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {
                               
                                OnlineTutorHiringSystem.Teacher.LoggedInTeacherEmail = emailText.Text.Trim();

                               
                                OnlineTutorHiringSystem.Teacher tForm = new OnlineTutorHiringSystem.Teacher();
                                tForm.Show();
                                this.Hide();


                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                emailText.Focus();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            close signup = new close();
            signup.Visible = true;
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (emailText.Text == "Email")
            {
                emailText.Text = "";
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (emailText.Text == "")
            {
                emailText.Text = "Email";
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

        private void Login_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                if (password.Text != "Password")
                {
                    password.PasswordChar = '*';
                }
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (password.Text != "Password" && password.Text != "")
            {
                password.PasswordChar = showPass.Checked ? '\0' : '*';
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void caretaker_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_2(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void AdminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin adlog = new AdminLogin();
            adlog.Show();
            this.Hide();
        }

        private void Guardian_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
