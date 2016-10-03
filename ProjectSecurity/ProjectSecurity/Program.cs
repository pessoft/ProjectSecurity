using System;
using System.Windows.Forms;
using Security;

namespace ProjectSecurity
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var projectSecurity = new ProjectSecurity();
            Presenter.Presenter presenter = new Presenter.Presenter(projectSecurity, new SecurityManager(), new FileManager.FileManager());
            Application.Run(projectSecurity);
        }
    }
}
