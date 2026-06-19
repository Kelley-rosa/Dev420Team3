using System;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new DashboardForm()); // Temporarily set to run the DashboardForm for testing purposes
            //Application.Run(new AppointmentForm()); // Temporarily set to run the AppointmentForm for testing purposes
        }
    }
}
