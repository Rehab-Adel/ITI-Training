namespace Task5
{
    internal class Program
    {
        static int SumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int [] array = new int[5];
            Console.WriteLine("Enter array numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Sum of the array is: {0}", SumOfArray(array));
        }
    }
}
