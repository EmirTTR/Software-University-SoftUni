using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");
            List<string> validNames = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string user = words[i];
                if (user.Length>=3 && user.Length<=16)
                {
                    if (isValid(user))
                    {
                        validNames.Add(user);
                    }
                }
            }
                        Console.WriteLine(string.Join("\n",validNames));
        }

        static bool isValid(string user)
        {
           
            foreach (var item in user)
            {
                if (char.IsLetterOrDigit(item) || item=='_' || item=='-')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
