using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AccountValidator
    {
        public static bool ValidateAccount(string login, string password, string confirmPassword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(login) || login.Length >= 20 || login.Contains(" "))
                {
                    throw new WrongLoginException("Incorrect value for login");
                }

                if (string.IsNullOrWhiteSpace(password) || password.Length >= 20 || password.Contains(" ") || !ContainsDigit(password))
                {
                    throw new WrongPasswordException("Incorrect value for password");
                }

                if (password != confirmPassword)
                {
                    throw new WrongPasswordException("Password mismatch");
                }

                return true;
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private static bool ContainsDigit(string value)
        {
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
