using System;
using System.Collections.Generic;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]url=Console.ReadLine().Split("\\");
            for (int i = 0; i < url.Length; i++)
            {
                List<string> partsFromUrl = new List<string>();
                if (url[i].Contains("."))
                {
                    partsFromUrl.Add(url[i]);
                    string[] split = url[i].Split(".");
                    string fileName = split[0];
                    string extension = split[1];
                    Console.WriteLine($"File name: {fileName}");
                    Console.WriteLine($"File extension: {extension}");
                    break;
                }
     
            }


        }
    }
}
