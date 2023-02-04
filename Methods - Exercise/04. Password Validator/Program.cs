using System;
namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isFirstTrue = CheckPasswordLength(password);
            bool isSecondTrue = CheckPasswordLetterAndDigit(password);
            bool isThirdTrue = CheckPasswordMinimumDigits(password);

            if (isFirstTrue)
            {
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }

            if (isSecondTrue)
            {
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (isThirdTrue)
            {
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isFirstTrue && isSecondTrue && isThirdTrue)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckPasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckPasswordLetterAndDigit(string password)
        {
            int passwordLength = password.Length;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57) || (password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122))
                {
                    counter++;
                }
            }
            if (counter == passwordLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CheckPasswordMinimumDigits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}