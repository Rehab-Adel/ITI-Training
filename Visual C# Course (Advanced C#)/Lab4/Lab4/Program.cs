using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of grades for each student:");
            int numberOfGrades = Convert.ToInt32(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Enter the name of student {i + 1}:");
                string name = Console.ReadLine();

                Student student = new Student(numberOfGrades) { Name = name };
                for (int j = 0; j < numberOfGrades; j++)
                {
                    Console.WriteLine($"Enter grade {j + 1} for {name}:");
                    student[j] = Convert.ToInt32(Console.ReadLine());
                }

                students.Add(student);
            }

            Console.WriteLine("Students' grades:");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}'s grades: {string.Join(", ", GetGrades(student, numberOfGrades))}");
            }
        }

        static List<int> GetGrades(Student student, int numberOfGrades)
        {
            List<int> gradesList = new List<int>();
            for (int i = 0; i < numberOfGrades; i++)
            {
                gradesList.Add(student[i]);
            }
            return gradesList;
        }
    }
}
