using System;

namespace Lab2
{
    internal class Employee
    {
        private int id;
        private string name;
        private int salary;
        private static string company = "ABC";
        private static int count = 0;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Use a private constructor for count incrementation
        private Employee()
        {
            count++;
        }

        public Employee(int id, string name, int salary) : this()
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void PrintEmpData()
        {
            Console.WriteLine($"Your id: {id}");
            Console.WriteLine($"Your name: {name}");
            Console.WriteLine($"Your salary: {salary}");
            Console.WriteLine($"Your company: {company}");
        }

        public static int GetCount()
        {
            return count;
        }

        ~Employee()
        {
            count--;
        }
    }
}
