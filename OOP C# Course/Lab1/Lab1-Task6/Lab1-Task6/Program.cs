namespace Lab1_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);
        }
    }
}
