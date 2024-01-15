namespace Task4
{
    internal class Program
    {
        static int GetReversedNumber(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            int ReversedNumber = int.Parse(number);
            return ReversedNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string UserInput = Console.ReadLine();
            Console.Write("Reverse number is: ");
            GetReversedNumber(UserInput);
        }
    }
}