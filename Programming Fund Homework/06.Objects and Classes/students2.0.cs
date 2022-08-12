using System;
using System.Collections.Generic;

namespace _05._Students_2._0
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

                if (isStudentExist(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };
                    students.Add(student);
                }
                input = Console.ReadLine();
               
            }
            string filteredCity = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.City == filteredCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

         static Student GetStudent(List<Student> students, string firstName, string lastName)
         {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName==firstName && student.LastName==lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
         }

        static bool isStudentExist(List<Student> students, string firstName, string lastName)
         {
            foreach  (Student student in students)
            {
                if (student.FirstName==firstName && student.LastName==lastName)
                {
                    return true;
                }
            }
            return false;
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
