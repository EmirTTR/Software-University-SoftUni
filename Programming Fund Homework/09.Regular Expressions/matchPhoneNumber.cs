using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/////////////////
namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            string[] matchPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchPhones));
            //string input = Console.ReadLine();
            //Regex mateches = new Regex(@"(\+359( ?-?)2\1[0-9]{3}\1[0-9]{4})\b");
            //MatchCollection phoneMatches = mateches.Matches(input);
            //List<string> phoneList = new List<string>();

            //foreach (var item in phoneMatches)
            //{
            //    phoneList.Add(item.ToString());
            //}

            //Console.WriteLine(string.Join(", ",phoneList));
        }
    }
}
