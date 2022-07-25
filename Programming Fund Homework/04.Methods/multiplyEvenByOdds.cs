using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = MultiplyEvenOds(number);
            Console.WriteLine(result);

        }
        static int MultiplyEvenOds(int number)
        {
            int result = SumOfEvens(number) * SumOfOds(number);
            return result;
        }
        static int SumOfOds(int number)
        {
            int sumOfOds = 0;

            while (number != 0)
            {
                int odd = number % 10;
                if (odd % 2 == 1)
                {
                    sumOfOds += odd;
                }

                number -= odd;
                odd /= 10;
            }

            return sumOfOds;
        }

        static int SumOfEvens(int number)
        {
            int sumOfEvens = 0;

            while (number != 0)
            {
                int even = number % 10;
                if (even % 2 == 0)
                {
                    sumOfEvens += even;
                }

                number -= even;
                even /= 10;
            }

            return sumOfEvens;
        }
    }
}