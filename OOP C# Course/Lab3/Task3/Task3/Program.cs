namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayOfNumbers = new int[10];
            
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                Console.WriteLine("Enter a  number");
                ArrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }
            int min = ArrayOfNumbers[0], flag = -1;
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                if (ArrayOfNumbers[i] < min)
                    min = ArrayOfNumbers[i];
                if (ArrayOfNumbers[i] % min == 0 && ArrayOfNumbers[i+1] % min == 0)
                {
                    Console.WriteLine($"Dividable numbers is: {min}");
                    flag++;
                    break;
                }
            }
            if ( flag == -1)
            {
                Console.WriteLine("there is no number");
            }
                
        }
    }
}
