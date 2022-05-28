using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

                // password validation rules are:
                //•	It should contain 6 – 10 characters(inclusive)
                //•	It should contain only of letters and digits
                //•	It should contain at least 2 digits
                //If it is not valid, for any unfulfilled rule print the corresponding message:
                //•	"Password must be between 6 and 10 characters"
                //•	"Password must consist only of letters and digits"
                //•	"Password must have at least 2 digits"

            string password = Console.ReadLine();
            bool isPasswordLenghtValid = validatedPasswordLenght(password);
            bool isPasswordContainsValidSymbols = validPasswordText(password);
            bool isDigitsInPasswordAtLeastTwo = validatePasswordDigits(password);

            if (!isPasswordLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isDigitsInPasswordAtLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isDigitsInPasswordAtLeastTwo && isPasswordContainsValidSymbols && isPasswordLenghtValid)
            {
                Console.WriteLine("Password is valid");
            }



        }

        private static bool validatePasswordDigits(string password)
        {
            int countDigit = 0;
            foreach (char character in password)
            {
                if (char.IsDigit(character))
                {
                    countDigit++;
                }
            }
            return countDigit >= 2;
        }

        private static bool validPasswordText(string password)
        {
            foreach (char character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool validatedPasswordLenght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
