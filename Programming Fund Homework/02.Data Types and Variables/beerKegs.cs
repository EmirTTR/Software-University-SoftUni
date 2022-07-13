using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberKegs = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double maxNum = double.MinValue;
            

            for (int i = 0; i < numberKegs; i++)
            {
                string kegName = Console.ReadLine();
                float kegWidth = float.Parse(Console.ReadLine());
                float kegHeight = float.Parse(Console.ReadLine());
                
                double currentVolume = Math.PI * kegWidth * kegWidth * kegHeight;

                if (currentVolume>maxNum)
                {

                    maxNum=currentVolume;
                    biggestKeg = kegName;
                }


                
            }
                    Console.WriteLine(biggestKeg);
        }
    }
}
