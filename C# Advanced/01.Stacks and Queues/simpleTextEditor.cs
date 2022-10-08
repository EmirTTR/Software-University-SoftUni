using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCommands = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> textStack = new Stack<string>();

            textStack.Push(text.ToString());
            for (int i = 0; i < nCommands; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];

                switch (command)
                {
                    case "1":
                        text.Append(input[1]);
                        textStack.Push(text.ToString());
                        break;
                    case "2":
                        int index = int.Parse(input[1]);
                        text.Remove(text.Length - index, index);
                        textStack.Push(text.ToString());
                        break;
                    case "3":
                        int place = int.Parse(input[1]);
                        Console.WriteLine(text[place-1]);
                        break;
                    case "4":
                        textStack.Pop();
                        text = new StringBuilder();
                        text.Append(textStack.Peek());
                        break;

                    default:
                        break;
                }
            }
           
        }
    }
}
