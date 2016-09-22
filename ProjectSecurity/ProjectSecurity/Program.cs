using System;
using System.Windows.Forms;
using Security.Encryption.SymmetricEncryption;
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
            var encryption = new CaesarCode();
            Presenter.Presenter presenter = new Presenter.Presenter(projectSecurity, encryption, new FileManager.FileManager());
            Application.Run(projectSecurity);
        }
    }
}
