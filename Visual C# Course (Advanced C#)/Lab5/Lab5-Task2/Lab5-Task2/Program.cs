namespace Lab5_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student1 = new Student()
                {
                    Name = "Rehab",
                    Id = 123,
                    Degrees = 200
                };
                Student student2 = new Student();
                student2.Name = "Mariam";
                student2.Id = 456;
                student2.SetDegrees("150");

                student1.PrintStudentData();
                student2.PrintStudentData();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
