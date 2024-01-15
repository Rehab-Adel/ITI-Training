namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            double total = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a matrix number: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    total += arr[i, j];
                }
            }
            Console.WriteLine("The average of the metrix is: {0}" ,total / 9);
        }
    }
}
