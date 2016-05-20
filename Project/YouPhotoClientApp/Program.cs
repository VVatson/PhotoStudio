using System;
using System.Windows.Forms;
using YouPhotoClientApp.Views.Controls;

namespace YouPhotoClientApp
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
            Application.Run(new AutorizationView(new Model.Model(new Connection.Connector())));
        }
    }
}
