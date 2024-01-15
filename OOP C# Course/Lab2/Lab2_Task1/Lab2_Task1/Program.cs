namespace Lab2_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i<=number; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
