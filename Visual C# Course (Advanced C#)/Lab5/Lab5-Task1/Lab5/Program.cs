namespace Lab5
{
    internal delegate void Delegates(int number);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 100: ");
            int num = int.Parse(Console.ReadLine());

            Delegates checkDelegate = Check;

            checkDelegate(num);
        }

        static void Check(int number)
        {
            if (number < 1)
            {
                Console.WriteLine("Less than 1");
            }
            else if (number > 100)
            {
                Console.WriteLine("Out of Range");
            }
            else
            {
                Console.WriteLine("Valid Number");
            }
        }
    }
}
