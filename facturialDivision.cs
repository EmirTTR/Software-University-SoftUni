using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
           
             double result =  DivideFacturiel(num1, num2);
             Console.WriteLine($"{result:f2}");
            
        }

        static double DivideFacturiel(double num1, double num2)
        {
            double result = 0;
            double result1 = num1;

            for (double i = num1-1; i >= 2; i--)
            {
                result1 *= i;
            }

            double result2 = num2; ;
            for (double i = num2 - 1; i >= 2; i--)
            {
                result2 *= i;
            }

            result = result1 / result2;
            return result;
        }
    }
}
