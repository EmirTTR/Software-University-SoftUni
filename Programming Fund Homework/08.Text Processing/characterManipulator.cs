using System;
using System.Collections.Generic;
//////////
namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<Strings> words = new List<Strings>();
            int sum = 0;
            int fulSum = 0;
            char firstChar;
            char secondChar;


            string[] split = word.Split(" ");

            string firstName = split[0];
            string secondName = split[1];
            for (int p = 0; p < split[0].Length; p++)
            {
                for (int j = 0; j < split[1].Length; j++)
                {
                    if (firstName.Length > p && secondName.Length > j)
                    {
                        firstChar = firstName[p];
                        secondChar = secondName[j];
                        sum = firstChar * secondChar;
                        fulSum += sum;
                    }
                    else if (firstName.Length > secondName.Length)
                    {
                        firstChar = firstName[p];
                        sum = firstChar;
                        fulSum += sum;
                    }
                    else if (secondName.Length > firstName.Length)
                    {
                        secondChar = secondName[j];
                        sum = secondChar;
                        fulSum += sum;
                    }
                    p++;
                }
                continue;

            }
            Console.WriteLine(fulSum);
        }
    }
    class Strings
    {
        Strings()
        {
            string firstString = FirstString;
            string secondString = SecondString;
        }

        public string FirstString { get; set; }
        public string SecondString { get; set; }
    }

}
