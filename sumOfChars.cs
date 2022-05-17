using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCahars = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numCahars; i++)
            {
                char otherChars = char.Parse(Console.ReadLine());
                sum += otherChars;

            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
