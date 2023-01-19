using System;
////////////////
namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result=SubstractSum(num1, num2,num3);
            Console.WriteLine(result);

        }

         static int SubstractSum(int num1, int num2,int num3)
         {
            int result = AddNums(num1, num2);
            result -= num3;
            return result;

         }

        static int AddNums(int num1, int num2)
        {
            int result = 0;
            result = num1 + num2;
            return result;
        }
    }
}
