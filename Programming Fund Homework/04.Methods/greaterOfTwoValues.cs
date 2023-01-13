using System;
using System.ComponentModel.Design.Serialization;
using Microsoft.Win32.SafeHandles;
//////////////
namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (input == "int")
            {
                int firstNum = int.Parse(firstValue);
                int secondNum = int.Parse(secondValue);
                Console.WriteLine(GetMaxInt(firstNum, secondNum));
            }

            else if (input == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                Console.WriteLine(GetMaxChar((char) firstChar, (char) secondChar));
            }
            else if (input == "string")
            {
                string firstString =firstValue;
                string secondString = secondValue;
                Console.WriteLine(GetMaxString(firstString, secondString));
            }
        }

        static string GetMaxString(string firstString, string secondString)
        {

            string result = string.Empty;
            int comparison = firstString.CompareTo(secondString);
            if (comparison > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }

            Console.WriteLine(result);
            
        }
            static int GetMaxInt(int firstNum, int secondNum)
            {
                if (firstNum > secondNum)
                {
                    return firstNum;
                }

                return secondNum;
            }

            static char GetMaxChar(char firstChar, char secondChar)
            {
                if (firstChar > secondChar)
                {
                    return firstChar;
                }

                return secondChar;
            }
    }
}
