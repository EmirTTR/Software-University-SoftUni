using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int ascii = int.Parse(Console.ReadLine());
            int asciii = int.Parse(Console.ReadLine());

            

            for (int i = ascii; i <= asciii; i++)
            {

                Console.Write($" {((char)i)}");
            }
        }
    }
}
    

