using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
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
            SignUp signUp = new SignUp();

            if (signUp.ShowDialog() == DialogResult.OK)
            {
                if (!signUp.IsDisposed)
                {
                    Application.Run(new Main());
                }
            }
        }
    }
}
