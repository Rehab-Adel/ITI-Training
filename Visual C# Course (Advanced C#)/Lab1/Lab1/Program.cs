namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Your Data:");
            employee.GetDataFromEmp();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Your Data is:");
            employee.PrintEmpData();
        }
    }
}
