namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter the matrix: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string[] rowInput = Console.ReadLine().Split(' ');
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(rowInput[j]);
                }
            }
            Console.WriteLine("The reversed matrix is: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[2 - i, 2 - j] +  " ");
                }
                Console.WriteLine();
            }


        }
    }
}
