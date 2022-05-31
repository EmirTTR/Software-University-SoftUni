using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            PolindromOrNot(word);
        }

         static void PolindromOrNot(string word)
         {
             while (word!="END")
             {
                 string input=String.Empty;
                 for (int i = 0; i <word.Length; i++)
                 {
                     input += word[i];
                 }
                 if (input[0]==input[input.Length-1])
                 {
                     Console.WriteLine("true");
                 }
                 else
                 {
                     Console.WriteLine("false");
                 }
                 word = Console.ReadLine();

             }
         }
    }
}
