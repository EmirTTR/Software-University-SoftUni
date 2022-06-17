using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            BigInteger sumOfNums = 0;

            if (num2>=0 && num2<=9)
            {
                sumOfNums = num * num2;
                Console.WriteLine(sumOfNums);
            }
        }
    }
}
