using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string seccond = Console.ReadLine();
            string third = Console.ReadLine();

            Console.WriteLine($"{first}{third}{seccond}");
        }
    }
}
