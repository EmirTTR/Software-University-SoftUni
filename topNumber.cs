using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TopNumber(num);
        }

         static void TopNumber(int num)
         {
             int sum = 0;
             int sumNext = 0;
             for (int i = 1; i <= num; i++)
             {
                 sum = i + i + 1;
                 int sum1 = sum;

                 if (sum > 10)
                 {
                     while (sum != 0)
                     {
                         int nextNum = sum % 10;
                         sum-= nextNum;
                         sum /= 10;
                         sumNext += nextNum;

                         if (nextNum % 2 == 1)
                         {
                             if (sumNext % 8 == 0)
                             {

                                 if (sum1 <= num)
                                 {
                                     Console.WriteLine(sum1);


                                 }
                             }
                         }

                     }
                     sumNext = 0;
                 }

                sum = 0;
             }
         }
    }
}
