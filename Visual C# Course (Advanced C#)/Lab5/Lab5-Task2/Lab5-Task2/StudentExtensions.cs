using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Task2
{
    internal static class StudentExtensions
    {
        public static void PrintStudentData(this Student student)
        {
            Console.WriteLine($"{student.Name}'s ID: {student.Id}, Degrees: {student.Degrees}");
        }
    }
}
