using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FoodProduct : Product, IProduct
    {
        public double ProductsRate { get; set; }
        public string[] ShowCollection { get; set; }

        public FoodProduct(int Id, string Name, int Price, string Description, double Quantity, string ImgUrl, double ProductsRate, string[] ShowCollection)
           : base(Id, Name, Price, Description, ImgUrl, Quantity)
        {

            this.ProductsRate = ProductsRate;
            this.ShowCollection = ShowCollection;
        }

        public override double CalcPrice(double tax)
        {
            return Price + ProductsRate - tax;
        }

        public override void ShowType()
        {
            Console.WriteLine("Food");
        }

        public void GetBestSeller(string[] BestSeller)
        {
            foreach (string b in BestSeller)
            {
                Console.WriteLine(b);
            }
        }
    }
}
