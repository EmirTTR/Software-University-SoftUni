using System;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] censoredWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var item in censoredWords)
            { 
              text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}
