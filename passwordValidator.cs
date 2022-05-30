using System;
using System.Collections.Concurrent;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordIsValid(password);

        }
        static void PasswordIsValid(string password)
        {
            char word = ' ';
            int count = 0;

            bool isDigitOrLetter = (word == '0' && word == '9' ) || (word == 'a' && word == 'z');
            bool isDigit = word == 0 && word == 9;

            bool isNotDigit = !isDigitOrLetter;

            for (int i = 0; i < password.Length; i++)
            {
                word = password[i];
                isDigitOrLetter = true;
                isDigit =false;
                isNotDigit = false;


                if (password.Length >= 6 && password.Length <= 10)
                {
                    if (isDigitOrLetter)
                    {
                        if (isDigit == true)
                        {
                            count++;
                        }
                    }
                }
            }

            if (password.Length < 6 || password.Length>10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (isDigitOrLetter==false )
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (isNotDigit == true)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (count >= 2)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits ");
            }

        }
    }
}