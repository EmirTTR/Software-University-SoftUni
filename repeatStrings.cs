using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(" ");
            StringBuilder repeat = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j <word[i].Length; j++)
                {
                    repeat.Append(word[i]); 
                }
            }
            Console.WriteLine(repeat);
        }
    }
}
