namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int factorial = 1;
                for (int j = 1; j < numbers[i]; j++)
                {
                    factorial *= numbers[j];
                }
                Console.WriteLine($"The factorial of number {i+1} is {factorial}");
            }
        }
    }
}
