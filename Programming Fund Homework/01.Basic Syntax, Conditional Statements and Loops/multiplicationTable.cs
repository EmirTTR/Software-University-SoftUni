using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
                int times = 1;

            do
            {
                Console.WriteLine($"{n} X {times} = {times*n}");
                times++;

            } while (times<=10);
           
        }
    }
}
