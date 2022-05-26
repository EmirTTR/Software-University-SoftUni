using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            recArea(num1,num2);
        }

        static void recArea(int number1,int number2)
        {
            int result = 0;
            result = number1 * number2;
            Console.WriteLine(result);
        }
    }
}
