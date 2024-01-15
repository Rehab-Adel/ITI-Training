namespace Lab1_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 3: ");
            int number3 = int.Parse(Console.ReadLine());

            int min, max;
            //max
            if (number1 > number2 && number1 > number3)
            {
                max = number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                max = number2;
            }
            else
            {
                max = number3;
            }
            //min
            if (number1 < number2 && number1 < number3)
            {
                min = number1;
            }
            else if (number2 < number1 && number2 < number3)
            {
                min = number2;
            }
            else
            {
                min = number3;
            }

            Console.WriteLine("Max number is: " + max);
            Console.WriteLine("Min number is: " + min);
        }
    }
}
