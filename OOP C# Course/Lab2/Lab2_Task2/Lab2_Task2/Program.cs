namespace Lab2_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i<= 12; i++)
            {
             
                Console.Write(i * num + " ");
                
            }
        }
    }
}
