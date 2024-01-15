using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2_Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            long reversed = 0;
            long r_num = long.Parse(Console.ReadLine());

            while (r_num > 0)
            {
                long digit = r_num % 10;
                reversed = reversed * 10 + digit;
                r_num /= 10;
            }
            Console.WriteLine($"Reversed numbers is: {reversed}");
        }
    }
}
