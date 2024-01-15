namespace Lab2_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Positive numbers: ");
            int count = int.Parse(Console.ReadLine());

            int max = 0;
            while (count >= 0)
            {
                if (count > max)
                    max = count;
                else
                    count = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The max integer is = " + max);
        }
    }
}
