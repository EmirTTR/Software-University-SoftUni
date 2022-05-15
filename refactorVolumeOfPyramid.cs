using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height;
            length = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            double pyramid = (length * width * height)/3;

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.Write($"Pyramid Volume: {pyramid:f2}");
        }
    }
}
