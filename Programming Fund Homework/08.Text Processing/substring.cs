using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string text = Console.ReadLine();

            int indexOF = text.IndexOf(remove);

            while (indexOF>=0)
            {
                text = text.Remove(indexOF, remove.Length);
                indexOF = text.IndexOf(remove);
            }
            Console.WriteLine(text);
        }
    }
}
