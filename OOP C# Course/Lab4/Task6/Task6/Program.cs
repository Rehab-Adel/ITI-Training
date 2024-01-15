namespace Task6
{
    internal class Program
    {
        static int maxOfArray(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter array numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Max number of the array is: "+ maxOfArray(array));
        }
    }
}
