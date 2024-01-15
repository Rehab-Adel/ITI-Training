using System.Security.Cryptography;

namespace Lab2_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_num, last_num, i, j;
            Console.WriteLine("Enter the Interval :- ");
            first_num = int.Parse(Console.ReadLine());
            last_num = int.Parse(Console.ReadLine());

            for (i = first_num; i <last_num; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }

                if (j == i)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
