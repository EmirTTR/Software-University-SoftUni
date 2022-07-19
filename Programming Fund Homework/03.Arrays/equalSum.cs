using System;
using System.Linq;

namespace _06._Equal_Sum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            
            bool isFound = false;


            for (int i = 0; i < num.Length; i++)
            {
                int sumFirst = 0;

                for (int k = 0; k < i; k++)
                {
                    sumFirst += num[k];
                }

                int sumSecond = 0;
                for (int j = num.Length - 1; j > i; j--)
                {
                    sumSecond += num[j];

                }
                    if (sumFirst==sumSecond && !isFound)
                    {
                        Console.WriteLine(i);
                        isFound = true;
                    }
            }

                if (!isFound)
                {
                    Console.WriteLine("no");
                }
        }   
            
                
        
    }
}
