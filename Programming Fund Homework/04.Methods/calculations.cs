using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int numerTwo = int.Parse(Console.ReadLine());
            

            mathTypes(type,number,numerTwo);
        }

        static void mathTypes(string word, int num,int num2)
        {
            if (word == "add")
            {
                int resultAdd;
                resultAdd = num + num2;
                Console.WriteLine(resultAdd);
            }
            if (word=="subtract")
            {
                int resultSum = num - num2;
                Console.WriteLine(resultSum);
            }
            if (word == "multiply")
            {
                int resultMul = num * num2;
                Console.WriteLine(resultMul);
            }
            if (word == "divide")
            {
                int resultDiv = num / num2;
                Console.WriteLine(resultDiv);
            }
        }
    }
}
