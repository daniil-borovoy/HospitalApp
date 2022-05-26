using System;
using System.Windows.Forms;

namespace HospitalApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Screensaver screensaver = new Screensaver();
            DateTime dateTime = DateTime.Now + TimeSpan.FromSeconds(2.5);
            screensaver.Show();
            while (DateTime.Now < dateTime)
            {
                Application.DoEvents();
            }
            screensaver.Close();
            screensaver.Dispose();

            Application.Run(new MainForm());
        }
    }
}
