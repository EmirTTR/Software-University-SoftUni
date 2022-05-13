using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal centurees = decimal.Parse(Console.ReadLine());
            decimal years = centurees * 100;
            decimal days = (int)(years * 365.2422m);
            decimal hours = (days * 24);
            decimal minutes = hours * 60;

            Console.WriteLine($"{centurees} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
