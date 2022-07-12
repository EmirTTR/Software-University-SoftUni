using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number ; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        char first = (char)('a' + i);
                        char seccond=(char)('a' + j);
                        char third=(char)('a' + k);


                        Console.WriteLine($"{first}{seccond}{third}");
                    }
                }
            }
        }
    }
}
