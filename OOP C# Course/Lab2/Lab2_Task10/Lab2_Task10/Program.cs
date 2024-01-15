namespace Lab2_Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            long MaxDigit = 0;
            long integer = long.Parse(Console.ReadLine());
            for (long temp = integer; temp > 0; temp /= 10)
            {
                long digit = temp % 10;
                if (digit > MaxDigit)
                {
                    MaxDigit = digit;
                }
            }
            Console.WriteLine($"Max Digit is: {MaxDigit}");
        }
    }
}
