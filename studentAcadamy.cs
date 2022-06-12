using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> studentsDict = new Dictionary<string, double>();
            double count = 1;

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsDict.ContainsKey(studentName))
                {
                    studentsDict.Add(studentName, studentGrade);
                }
                else
                {
                    studentsDict[studentName] += studentGrade;
                    count++;
                    studentsDict[studentName] /= count;
                    count = 1;
                }
            }
            foreach (var item in studentsDict.Where(x => x.Value >= 4.50))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
