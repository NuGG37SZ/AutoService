using System;
using System.Windows.Forms;

namespace AutoService
{
    internal static class Program
    {
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
