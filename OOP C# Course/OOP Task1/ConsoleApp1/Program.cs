namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array 
            string[] productArray = { "item1", "item2", "item3" };
            string[] FashionProductArray = { "item6", "item9", "item13" };
            Console.WriteLine("___________________________default constructor______________________");
            Product product1 = new Product();
            //print product1 with default constructor values
            product1.Print();
            Console.WriteLine("______________________parameterized constructor___________________________");
            Product product2 = new Product(1, "prod2", 5000, productArray, "good", 5, 4.7);
            //print product1 with parameterized constructor values
            product2.Print();
            Console.WriteLine("______________________chained constructor___________________________");
            Product product3 = new Product(1, "prod3", 4000);
            //print product1 with parameterized constructor values
            product3.Print();
            Console.WriteLine();
            Console.WriteLine("____________________________________________Fashion Product______________________________________");
            //fashion product new object
            FashionProduct product4 = new FashionProduct();
            FashionProduct product5 = new FashionProduct(5, "fashioProduct", 1000, productArray, "good", 4, 3.7, 4, FashionProductArray);
             Console.WriteLine("____________________________________________ default constructor______________________________________");
            product4.Print();
             Console.WriteLine("____________________________________________ chain and parameterized constructor______________________________________");
            product5.Print();

            Console.WriteLine();
            Console.WriteLine("____________________________________________Electric Product______________________________________");
            //fashion product new object
            ElectricProduct product6 = new ElectricProduct();
            ElectricProduct product7 = new ElectricProduct(5, "ElectricProduct", 2000, productArray, "good", 4, 3.7, 4,productArray);
            Console.WriteLine("____________________________________________ default constructor______________________________________");
            product6.Print();
            Console.WriteLine("____________________________________________ chain and parameterized constructor______________________________________");
            product7.Print();
            Console.ReadLine();


        }
    }
}
