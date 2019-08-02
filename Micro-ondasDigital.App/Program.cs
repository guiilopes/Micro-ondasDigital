using System;
using System.Windows.Forms;

namespace MicroondasDigital.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Servicos.CarregarKernel();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MicroondasDigital());
        }
    }
}
