namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            double total = 0;
            Console.WriteLine("Enter array numbers:");
            for (int i = 0; i< numbers.Length; i++)
            {
                
                numbers[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i =0; i< numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine($"The average of the array: {total / 10}");

        }
    }
}
