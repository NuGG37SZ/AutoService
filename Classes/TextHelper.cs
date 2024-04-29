using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Classes
{
    public class TextHelper
    {
        private static Dictionary<Control, string> initialTexts = new Dictionary<Control, string>();

        public static void ClearText(Control control)
        {
            SaveInitialText(control);
            control.Text = string.Empty;
        }

        public static void RestoreText(Control control)
        {
            if (initialTexts.ContainsKey(control))
            {
                control.Text = initialTexts[control];
            }
        }

        private static void SaveInitialText(Control control)
        {
            if (!initialTexts.ContainsKey(control))
            {
                initialTexts.Add(control, control.Text);
            }
        }
    }
}
