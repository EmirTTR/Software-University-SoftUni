using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =int.Parse(Console.ReadLine());
            int count = 0;
          
            for (int i = 1; i <= num; i++)
            {
               
                for (int j = i; j < i+num-1; j++)
                    Console.Write(num + " ");
                {  
                    Console.WriteLine(num);
                }
            }
        }
    }
}
