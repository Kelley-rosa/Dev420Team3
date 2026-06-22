using System;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class MainForm : Form
    {
        // holds the currently logged in user
        private User loggedInUser;

        public MainForm()
        {
            InitializeComponent();
            this.Name = "MainForm";
        }

        // allows the login form to pass the logged in user back to the main form
        public void SetLoggedInUser(User user)
        {
            loggedInUser = user;
            label_loggedInUser.Text = "Logged in as: " + user.Username + " (" + user.Role + ")";
        }

        // helper method to check if someone is logged in
        private bool IsLoggedIn()
        {
            if (loggedInUser == null)
            {
                MessageBox.Show("Please log in first.", "Not Logged In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // opens the login form
        private void button_login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        // opens the register form
        private void button_register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        // opens patient management, login required
        private void button_patientManagement_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn()) return;
            PatientManagementForm patientForm = new PatientManagementForm();
            patientForm.Show();
        }

        // opens analytics, login required
        private void button_analytics_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn()) return;
            AnalyticsForm analyticsForm = new AnalyticsForm();
            analyticsForm.Show();
        }

        // opens appointments form built by person 2
        private void button_appointments_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn()) return;
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        // opens dashboard form built by person 2
        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn()) return;
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }

        // opens inventory form built by person 3
        private void button_inventory_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn()) return;
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        // opens chat form built by person 3
        private void button_chat_Click(object sender, EventArgs e)
        {
            if (!IsLoggedIn()) return;
            ChatForm chatForm = new ChatForm();
            chatForm.Show();
        }
    }
}