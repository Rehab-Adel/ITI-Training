namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bestseller = { "product1", "product2" };
            string[] ShowCollection = { "pasta1", "pasta2", "pasta3" };
            string[] FashionTrend = { "tshirt1", "tshirt2", "tshirt3" };
            string[] electo = { "elect1", "elect2", "elect3" };

            FoodProduct foodproduct = new FoodProduct(1, "Pasta", 150, "des", 2, "3aa", 9, ShowCollection);

            FashionProject fashionproduct = new FashionProject(1, "tshirt", 150, "des", 2, "3aa", 9, FashionTrend);
            ELectronics elect = new ELectronics(1, "lamba", 150, "des", 2, "3aa", 9, electo);


            foodproduct.CalcPrice(50);
            foodproduct.ShowType();
            foodproduct.GetBestSeller(bestseller);

            fashionproduct.CalcPrice(70);
            fashionproduct.ShowType();
            fashionproduct.GetBestSeller(bestseller);

            elect.CalcPrice(90);
            elect.ShowType();
            elect.GetBestSeller(bestseller);

        }
    }
}