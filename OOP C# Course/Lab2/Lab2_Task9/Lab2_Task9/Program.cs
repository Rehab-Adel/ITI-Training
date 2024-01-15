namespace Lab2_Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int Horiz = int.Parse(Console.ReadLine());
            int vertic = int.Parse(Console.ReadLine());

            for (int i = 1; i<= Horiz; i++)
            {
                for (int j = 1; j <= vertic; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
