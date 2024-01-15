namespace Lab2_Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c_num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= c_num; i++)
            {
                for (int j = c_num - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int f = 1; f < i; f++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
