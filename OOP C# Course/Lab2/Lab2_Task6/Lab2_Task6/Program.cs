namespace Lab2_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int f_number = int.Parse(Console.ReadLine());
            for (int i = 1; i<= f_number; i++)
            {
                if (f_number%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
