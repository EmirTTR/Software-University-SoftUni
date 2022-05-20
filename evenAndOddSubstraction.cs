using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]%2==0)
                {
                    evenSum += num[i];

                }
                if (num[i]%2!=0)
                {
                    oddSum += num[i];
                }
                sum = evenSum - oddSum;


            }
            Console.WriteLine(sum);
        }
    }
}
