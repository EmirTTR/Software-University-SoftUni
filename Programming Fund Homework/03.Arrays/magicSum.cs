using System;
using System.Linq;
///////////////
namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
              int  currentNumber = array[i];

                for (int j = i+1; j < array.Length; j++)
                {
                    if (currentNumber + array[j] == number)
                    {
                        Console.WriteLine($"{currentNumber} {array[j]}");
                    }
                }
            }
            

            
        }
    }
}
