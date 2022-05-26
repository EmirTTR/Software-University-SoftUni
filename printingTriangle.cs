using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            printTriangle(num);
        }

        static void printTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int j = 1; j <=row; j++)
                {
                    
                    Console.Write( j + " ");
                }

                Console.WriteLine();
            }

            for (int i = number-1; i >=1; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
