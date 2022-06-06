using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] split = input.Split();
                string firstName = split[0];
                string lastName = split[1];
                int age = int.Parse(split[2]);
                string city = split[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName=lastName,
                    Age=age,
                    City=city
                };
                students.Add(student);
                input = Console.ReadLine();
            }
            string filteredCity = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.City==filteredCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
