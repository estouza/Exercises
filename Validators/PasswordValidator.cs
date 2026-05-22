using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Password.Validators
{
    public class PasswordValidator
    {
        public static bool IsValidPassword(string password)
        {

            if (password.Length <= 8 || password == "12345678")
            {
                return false;
            }
            else if (password.Contains('!') || password.Contains('@') || password.Any(char.IsDigit))
            {
                return true;
            }
            
            return false;
        }
    }
}
