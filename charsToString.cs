using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char seccond = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            Console.Write($"{first}{seccond}{third}");
        }
    }
}
