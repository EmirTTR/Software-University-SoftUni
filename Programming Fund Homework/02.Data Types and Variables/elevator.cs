using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int elevatorCapaciy = int.Parse(Console.ReadLine());

            int coureses = (int)Math.Ceiling((double)numPeople / elevatorCapaciy);
            

            
            
            
                Console.WriteLine($"{coureses}");
            

        }


    }
}
