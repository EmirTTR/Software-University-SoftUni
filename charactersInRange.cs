using System;
using System.Text;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            CharinRange(start, end);


        }
        static void CharinRange(char start, char end)
        {
            int startChar = Math.Min(start, end);
            int endChar = Math.Max(start, end);

            for (int i = startChar+1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
