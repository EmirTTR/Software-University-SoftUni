using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            repeatWord(word,num);
        }

        static void repeatWord(string word,int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(word);
            }
        }
    }
}
