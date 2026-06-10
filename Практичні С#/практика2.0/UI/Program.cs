using Services;
using UI.Main;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();

            var loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var currentUser = loginForm.CurrentUser;
                var manager = new ServiceManager();

                if (currentUser.Role == "Administrator")
                {
                    Application.Run(new AdminMainForm(manager, currentUser));
                }
                else if (currentUser.Role == "TechnicalSpecialist")
                {
                    Application.Run(new TechSpecialistMainForm(manager, currentUser));
                }
                else
                {
                    MessageBox.Show("Unknown user role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}