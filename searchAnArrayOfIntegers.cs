using System;
using System.Linq;

namespace Search_an_array_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string word = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                
                while (word != "End")
                {
                    
                    arr[i] = int.Parse(word);
                    word = Console.ReadLine();
                }
            

                if (word == "End")
                {
                    if (arr[i]==5)
                    {
                        Console.WriteLine($"The number {arr[i]} exist");
                    }
                }
                
            }
        }
    }
}
