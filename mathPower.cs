using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int numberPow = int.Parse(Console.ReadLine());

            double result = powerNum(number, numberPow);
            Console.WriteLine(result);
            
        }

        static double powerNum(double num1, int num2)
        {
            
            double result = num1;

            for (int i = 1; i < num2; i++)
            {
                result *= num1;
            }
            

            return result;

        }
    }
}
