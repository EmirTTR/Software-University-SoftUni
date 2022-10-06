using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songsQueue = new Queue<string>(songs);

            while (songsQueue.Count>0)
            {
                string input = Console.ReadLine();
                string[] splitInput = input.Split(" ");
                string command = splitInput[0];
                if (command=="Show")
                {
                    Console.WriteLine(string.Join(", ",songsQueue));
                }
                else if (command=="Add")
                {
                    string[] secondSplit = input.Split($"{command} ");
                    string songToAdd = secondSplit[1];
                  
                    if (!songsQueue.Contains(songToAdd))
                    {
                        songsQueue.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }
                else if (command=="Play")
                {
                    if (songsQueue.Count>0)
                    {
                        songsQueue.Dequeue();
                    }
                    
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
