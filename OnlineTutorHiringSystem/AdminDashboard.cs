using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineTutorHiringSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        // Action for clicking "Manage Admin"
        private void button3_Click(object sender, EventArgs e)
        {
            ManageAdmin manageAdmin = new ManageAdmin();
            manageAdmin.Show();
            this.Hide(); // Hides current dashboard to clear the screen
        }

        // Action for clicking "Manage Teacher"
        private void button2_Click(object sender, EventArgs e)
        {
            ManageTeacher manageTeacher = new ManageTeacher();
            manageTeacher.Show();
            this.Hide();
        }

        // Action for clicking "Manage Guardian"
        private void ManageGuardian_Click(object sender, EventArgs e)
        {
            ManageGuardian manageGuardian = new ManageGuardian();
            manageGuardian.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Logic to run when the dashboard first opens (if any)
        }

        // Optional: Logout button to return to the Admin Login page
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Close(); // Closes the dashboard entirely
        }
    }
}