using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operatorOfMat = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (operatorOfMat=='+')
            {
                 AddOperator(num1, num2);
            }
            else if (operatorOfMat=='-')
            {
                 SubtractOperator(num1, num2);
            }
            else if (operatorOfMat=='*')
            {
                MultiplyOfMat(num1, num2);
            }
            else if (operatorOfMat=='/')
            {
                DivideOfMat(num1, num2);
            }
            else
            {
                return;
            }
        }

        private static void DivideOfMat(int num1, int num2)
        {
            int sum = num1 / num2;
            Console.WriteLine(sum);
        }

        static void MultiplyOfMat(int num1, int num2)
         {
             int sum = num1 * num2;
             Console.WriteLine(sum);
         }

        static void SubtractOperator(int num1, int num2)
        {
            int sum = num1 - num2; 
            Console.WriteLine(sum);
        }

         static void AddOperator(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
