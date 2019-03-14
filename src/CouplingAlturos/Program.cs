using System;
using System.Windows.Forms;
using Autofac;

namespace CouplingAlturos
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

            var container = RegistrationService.CreateContainer();

			Application.Run(container.Resolve<MainForm>());
        }
    }
}
