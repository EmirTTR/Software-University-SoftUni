using System;
/
namespace _11.MultiplicationTable_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                var n = int.Parse(Console.ReadLine());
                int times = int.Parse(Console.ReadLine()) ;

                do
                {
                    Console.WriteLine($"{n} X {times} = {times * n}");
                    times++;

                } while (times <= 10);

            }
        }
    }

}
