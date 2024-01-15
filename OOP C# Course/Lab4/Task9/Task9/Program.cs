namespace Task9
{
    internal class Program
    {
        static int MaxOfArray(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i< arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > max)
                        max = arr[i,j];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[,] arrayy = new int[3, 3];
            Console.WriteLine("Enter array numbers: ");
            for (int i = 0; i < arrayy.GetLength(0); i++)
            {

                string[] rowInput = Console.ReadLine().Split(' ');
                for (int j = 0; j < arrayy.GetLength(1); j++)
                {
                    arrayy[i, j] = int.Parse(rowInput[j]);
                }
            }

            Console.WriteLine($"Max number of the matrix {MaxOfArray(arrayy)}");
                
        }
    }
}
