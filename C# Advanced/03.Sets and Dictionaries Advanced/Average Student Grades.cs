using System;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsDict = new Dictionary<string, List<decimal>>();
            decimal averageGrade = 0;
            decimal sumGrade = 0;
            
            

            for (int i = 0; i < numStudents; i++)
            {
                string input = Console.ReadLine();
                string[] inputParts = input.Split(" ");
                string name = inputParts[0];
                decimal grade = decimal.Parse(inputParts[1]);
                if (!studentsDict.ContainsKey(name))
                {
                    studentsDict.Add(name, new List<decimal>());
                }
                 studentsDict[name].Add(grade);
            }

            foreach (var item in studentsDict)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    decimal num = decimal.Parse(grade.ToString());
                    sumGrade += num;
                    Console.Write($"{grade:f2} ");
                }
                averageGrade = sumGrade / item.Value.Count;
                sumGrade = 0;
                Console.Write($"(avg: {averageGrade:f2})");
                Console.WriteLine();
            }
        }
    }
}
