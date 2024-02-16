using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    enum Positon { Manager = 1, Employee = 2}
    enum JobTime { PartTime = 1, FullTime = 1}
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public Positon position { get; set; }

        public JobTime time { get; set; }

        public void GetDataFromEmp()
        {
            Console.WriteLine(" Enter your id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine(" Enter your salary: ");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter your position: ");
            Console.WriteLine("  1- Manager \n  2- Employee");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                position = (Positon)1;

            }
            else
            {
                if (choice == 2)
                {
                    position = (Positon)2;
                }
            }

            Console.WriteLine(" Enter your Jop Time: ");
            Console.WriteLine("  1- Part Time \n  2- Full Time");
            int choice2 = int.Parse(Console.ReadLine());
            if (choice2 == 1)
            {
                time = (JobTime)1;

            }
            else
            {
                if (choice2 == 2)
                {
                    time = (JobTime)2;
                }
            }

        }

        public void PrintEmpData()
        {
            Console.WriteLine($"Your name: {id}");
            Console.WriteLine($"Your name: {name}");
            Console.WriteLine($"Your name: {salary}");

            Console.WriteLine($"Your Position is:{position} ");
            Console.WriteLine($"Your Job Time is: {time}");

        }
    }
}
