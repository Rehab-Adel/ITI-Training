namespace Lab2_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());
            for (int i = 2; i<= Num; i+=2)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
