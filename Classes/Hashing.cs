using System;
using System.Text;
using System.Security.Cryptography;

namespace AutoService.Classes
{
    public class Hashing
    {
        public static string Hash(string input)
        {
            using (var sha128 = SHA1.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha128.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
