using System;
using System.ComponentModel.Design;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
           string result=GetMidChar(word);
           Console.Write(result);

        }

        static string GetMidChar(string word)
        {
            int lenght = word.Length;
            string result=String.Empty;
            if (lenght % 2 == 1)
            {
                result = word[word.Length / 2].ToString();
            }
            else
            {
                result = word[word.Length / 2 - 1].ToString() + word[word.Length / 2].ToString();
            }

            return result;
        }
    }
}