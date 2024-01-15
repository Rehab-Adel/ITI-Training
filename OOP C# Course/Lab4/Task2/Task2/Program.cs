using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2
{
    internal class Program
    {
        static float GetAverageOfNumbers()
        {
            Console.WriteLine("Enter three numbers:");
            float total = 0;
            for (int i = 1; i<= 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                total += number;
            }
            return total;
        }

        static void Main(string[] args)
        {
            float Average = GetAverageOfNumbers() / 3;
            Console.WriteLine($"The average of three numbers is: {Average}");
        }
    }
}
