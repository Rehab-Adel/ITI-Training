namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String<int> s1 = new String<int>(2, 3);
            String<string> s2 = new String<string>("input1", "input2");
            Console.WriteLine("Please enter an input: ");
            s1.x = int.Parse(Console.ReadLine());
            s1.y = int.Parse(Console.ReadLine());
            Console.WriteLine(s1);
            Console.WriteLine("Please enter an input: ");
            s2.x = Console.ReadLine();
            s2.y = Console.ReadLine();
            Console.WriteLine(s2);

            Console.WriteLine("generic numer (2)");

            Calculate<int> calculate = new Calculate<int>();
            Console.WriteLine("1.Please enter you first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Please enter you sencond number");
            int y = int.Parse(Console.ReadLine());
            Calculate<int>.Swap(ref x, ref y);
            Console.WriteLine("X={0}", x);
            Console.WriteLine("Y={0}", y);

            Calculate<string> calculate1 = new Calculate<string>();
            Console.WriteLine("2.Please enter you first input");
            string w = (Console.ReadLine());
            Console.WriteLine("2.Please enter you sencond input");
            string z = (Console.ReadLine());
            Calculate<string>.Swap(ref w, ref z);
            Console.WriteLine("W={0}", w);
            Console.WriteLine("Z={0}", z);
        }
    }
}
