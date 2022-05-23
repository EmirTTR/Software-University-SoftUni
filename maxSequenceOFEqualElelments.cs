using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countEqual = 1;
            int numEqual = 0;
            int maxEqual = 0;
            int element = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    countEqual++;
                    
                }
                else
                {
                    countEqual = 1;
                }
                if (countEqual>maxEqual)
                {
                    maxEqual = countEqual;
                    element = numbers[i];
                    
                }
            }
                for (int j = 0; j < maxEqual; j++)
                {
                    Console.Write(element + " ");
                }
            
            
        }
    }
}
