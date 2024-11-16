using System;
using System.Windows.Forms;

namespace UAS_DB_PamerYuk
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Connection connection = new Connection();
            MainForm mainForm = new MainForm(connection);

            Application.Run(mainForm);
        }
    }
}
