namespace Task8
{
    internal class Program
    {
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2: ");
            int number2 = int.Parse(Console.ReadLine());
            swap(ref number1, ref number2);
            Console.Write($"First number after swapping: {number1}" + $", second number after swapping: {number2}");
        }
    }
}
