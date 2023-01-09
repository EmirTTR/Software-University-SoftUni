using System;
using System.Collections.Generic;
using System.Linq;
////////////
namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseDict = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" : ");

            while (input[0]!="end")
            {
                string courseName = input[0];
                string studentName = input[1];

                if (!courseDict.ContainsKey(courseName))
                {
                    courseDict.Add(courseName, new List<string>());
                    courseDict[courseName].Add(studentName);
                    
                }
                else
                {
                    courseDict[courseName].Add(studentName);
                    
                }

                input = Console.ReadLine().Split(" : ");
            }

            foreach (var course in courseDict)
            {
                Console.WriteLine($"{string.Join(" ", course.Key)}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    
                     Console.Write($"-- {string.Join("\n-- ",course.Value)}");
                    Console.WriteLine();
                    break;
                }
               
                
            }
        }
    }
}
