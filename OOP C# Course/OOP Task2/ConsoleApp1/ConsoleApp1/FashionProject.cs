using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FashionProject : Product, IProduct
    {
        public double FashionRate { get; set; }
        public string[] FashionTrend { get; set; }

        public FashionProject(int Id, string Name, int Price, string Description, double Quantity, string ImgUrl, double FashionRate, string[] FashionTrend)
            : base(Id, Name, Price, Description, ImgUrl, Quantity)
        {

            this.FashionRate = FashionRate;
            this.FashionTrend = FashionTrend;
        }
        public override double CalcPrice(double tax)
        {
            return Price + FashionRate - tax;
        }

        public override void ShowType()
        {
            Console.WriteLine("Fashion");
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
