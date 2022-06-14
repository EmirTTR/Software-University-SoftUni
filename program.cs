using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder diggits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder special = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    diggits.Append(word[i]);
                }
                else if (char.IsLetter(word[i]))
                {
                    letters.Append(word[i]);
                }
                else
                {
                    special.Append(word[i]);
                }
            }
            Console.WriteLine(diggits);
            Console.WriteLine(letters);
            Console.WriteLine(special);
        }
    }
}
