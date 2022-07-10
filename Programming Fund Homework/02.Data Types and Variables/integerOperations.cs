using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int seccondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            seccondNumber += firstNumber;
          int second =  seccondNumber / thirdNumber;
            forthNumber *= second;
            Console.WriteLine(forthNumber);
           
        }
    }
}
