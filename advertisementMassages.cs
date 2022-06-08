using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
               string[] rngPhrases = new string[]
               {
                   "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
               };
               string[] rngEvents = new string[]
               {
                  "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
               };
               string[] rngAuthors = new string[]
               {
                     "Diana",
                     "Petya",
                     "Stella",
                      "Elena",
                      "Katya",
                      "Iva",
                      "Annie",
                      "Eva"
               };
               string[] rngCities = new string[]
               {
                    "Burgas",
                    "Sofia",
                    "Plovdiv",
                    "Varna",
                    "Ruse"
               };


            int num = int.Parse(Console.ReadLine());
            Random phrase = new Random();
            Random event1 = new Random();
            Random author = new Random();
            Random town = new Random();
           

            for (int i = 0; i < num; i++)
            {
                int phrasee = phrase.Next(0, rngPhrases.Length);
                int authors = author.Next(0, rngAuthors.Length);
                int evvents = event1.Next(0, rngEvents.Length);
                int cities = town.Next(0, rngCities.Length);

                Console.WriteLine($"{rngPhrases[phrasee]} {rngEvents[evvents]} {rngAuthors[authors]} – {rngCities[cities]}.");

            }
        }
    }
}
