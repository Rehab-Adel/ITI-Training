namespace Lab2_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            int base_num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int Result = 1;
            for (int i = 1; i<= power; i++)
            {
                Result *= base_num; 
            }
            Console.WriteLine(Result);
        }
    }
}
