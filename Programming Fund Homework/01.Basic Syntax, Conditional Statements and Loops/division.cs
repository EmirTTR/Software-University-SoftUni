using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int twoNum = 2;
            int treeNum = 3;
            int sixNum = 6;
            int sevenNum = 7;
            int tenNum = 10;

            
           
            if (number%10==0)
            {
                Console.WriteLine($"The number is divisible by {tenNum}");
            }
            else if (number%7==0)
            {
                Console.WriteLine($"The number is divisible by {sevenNum}");

            }
            else if (number%6==0)
            {
                Console.WriteLine($"The number is divisible by {sixNum}");

            }
            else if (number%3==0)
            {
                Console.WriteLine($"The number is divisible by {treeNum}");

            }
            else if (number%2==0)
            {
                Console.WriteLine($"The number is divisible by {twoNum}");

            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
