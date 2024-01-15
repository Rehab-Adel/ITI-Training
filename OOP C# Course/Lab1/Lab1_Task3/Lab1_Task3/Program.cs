namespace Lab1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("Max number is: " + number1);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Max number is: " + number2);
            }
        }
    }
}
