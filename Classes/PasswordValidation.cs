using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Classes
{
    public class PasswordValidation
    {
        public static bool Validation(string password)
        {
            var input = password;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Поле с паролем пустое", "Ошибка");
                return false;
            }

            var hasMiniMaxChars = new Regex(@".{5,15}");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну строчную букву", "Ошибка");
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                MessageBox.Show("Пароль должен быть длиннее 5 символов", "Ошибка");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
