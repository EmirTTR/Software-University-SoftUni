using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection regex = Regex.Matches(input, @"\b[A-Z][a-z]+ [A-Z][a-z]+");

            foreach (Match item in regex)
            {
                Console.Write(item + " ");
            }
        }
    }
}
