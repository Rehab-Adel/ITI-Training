using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    internal class Program
    {
        static void PrintingAnInteger(int number)
        {
            Console.WriteLine($"The number is: {number}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer:");
            int UserInput = int.Parse(Console.ReadLine());
            PrintingAnInteger(UserInput);
        }
    }
}
