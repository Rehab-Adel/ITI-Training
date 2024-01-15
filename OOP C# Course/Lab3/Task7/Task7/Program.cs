namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter the matrix:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string[] rowItems = Console.ReadLine().Split(' ');
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(rowItems[j]);
                }
            }
            Console.WriteLine("Replaced matrix is:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)
                        Console.Write(0 + " ");
                    else
                        Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
