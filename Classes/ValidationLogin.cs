using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AutoService.Classes
{
    public class ValidationLogin
    {
        public static bool Validation(string login)
        {
            var input = login;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Поле с логином пустое", "Ошибка");
                return false;
            }

            var hasMiniMaxChars = new Regex(@".{5,12}");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                MessageBox.Show("Логин должен содержать хотя бы одну строчную букву", "Ошибка");
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                MessageBox.Show("Логин должен быть длиннее 5 символов", "Ошибка");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
