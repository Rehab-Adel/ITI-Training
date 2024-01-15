namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter array numbers");
            for (int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The reversed array:");
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
