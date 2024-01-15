namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Square root function : {0}", Math.Sqrt(num1));
            Console.WriteLine("Maximum function : {0}", Math.Max(num1, num2));
            Console.WriteLine("Minimum function : {0}", Math.Min(num1, num2));


        }
    }
}
