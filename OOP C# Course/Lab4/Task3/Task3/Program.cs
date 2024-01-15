using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i<= number/2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int InputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Is the number prime? {IsPrime(InputNumber)}");

        }
    }
}
