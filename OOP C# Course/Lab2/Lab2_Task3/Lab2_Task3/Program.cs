namespace Lab2_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive numbers: ");
            int counter = int.Parse(Console.ReadLine());
            int inf_number = 0;
            while (counter >= 0)
            {
                inf_number = inf_number + counter;
                counter = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of positive numbers= " + inf_number);
        }
    }
}