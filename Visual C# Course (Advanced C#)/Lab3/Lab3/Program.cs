namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent(1,2);
            Child1 child1 = new Child1(3,1,2);
            Child2 child2 = new Child2(1,2,3,1);

            //Console.WriteLine($"Output of parent function: {parent.Sum(9,4)}");
            //Console.WriteLine($"Output of child1 function: {child1.Sum(3,2)}");
            //Console.WriteLine($"Output of child+2 function: {child2.Sum(1,6)}");

            Print(parent);

            Print(child1);

            Print(child2);
                // 

            Print2(child1);
            Print2 (child2);
            // Print2(parent);
            //
           // Print3(child1);
            Print3(child2);
           // Print3(parent);
            Console.ReadLine();


        }
        static void Print(Parent p)
        {
            Console.WriteLine($"Sum from Print: {p.Sum(p.GetX(), p.GetY())}");
        }

        static void Print2(Child1 ch)
        {
            Console.WriteLine($"Sum from Print2: {ch.Sum(ch.GetX(), ch.GetY())}");
        }
        static void Print3 (Child2 ch)
        {
            Console.WriteLine(ch.Sum);

        }
    }
}
