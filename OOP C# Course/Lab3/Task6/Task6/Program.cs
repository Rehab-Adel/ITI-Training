namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] sumArray = new int[3, 3];
            Console.WriteLine("Enter matrix one:");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                string[] rowElements = Console.ReadLine().Split(' ');
                for (int j = 0; j < array1.GetLength(1); j++)
                    array1[i, j] = int.Parse(rowElements[j]);
            }
            Console.WriteLine("Enter matrix two:");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                string[] rowElements = Console.ReadLine().Split(' ');
                for (int j = 0; j < array2.GetLength(1); j++)
                    array2[i, j] = int.Parse(rowElements[j]);
            }
            Console.WriteLine("The sum matrix is");
            for (int i = 0; i < sumArray.GetLength(0); i++)
            {
                for(int j = 0; j <sumArray.GetLength(1); j++)
                {
                    sumArray[i, j] = array1[i, j] + array2[i, j];
                    
                    Console.Write(sumArray[i, j] + " ");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
