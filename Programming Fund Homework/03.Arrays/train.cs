using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagoons = int.Parse(Console.ReadLine());
            int[] peoples = new int[wagoons];
            int sum = 0;

            for (int i = 0; i < wagoons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                peoples[i] = people;
               
                

            }
            for (int i = 0; i < peoples.Length; i++)
            {
                sum += peoples[i];
                Console.Write(peoples[i] + " ");

            }
            Console.WriteLine(" ");
            Console.Write(sum);
                  
        }
    }
}
