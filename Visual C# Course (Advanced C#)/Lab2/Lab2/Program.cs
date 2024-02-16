namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First Employee's Data'");
            Employee emp1 = new Employee(1, "Rehab", 50000);
            emp1.PrintEmpData();
            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("Second Employee's Data'");
            Employee emp2 = new Employee(2, "Mariam", 40000);
            emp2.PrintEmpData();
            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("Second Employee's Data'");
            Employee emp3 = new Employee(3, "Esraa", 30000);
            emp3.PrintEmpData();
            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("Second Employee's Data'");
            Employee emp4 = new Employee(4, "Amany", 20000);
            emp4.PrintEmpData();
            Console.WriteLine("\n-------------------------------------------\n");


            Console.WriteLine($"Total employees: {Employee.GetCount()}");





            emp4 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine($"Total employees: {Employee.GetCount()}");

        }
    }
}
