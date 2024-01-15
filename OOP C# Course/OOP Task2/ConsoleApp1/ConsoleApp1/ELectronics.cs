using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ELectronics : Product, IProduct
    {
        public double ElectRate { get; set; }
        public string[] ElectTrend { get; set; }


        public ELectronics(int Id, string Name, int Price, string Description, double Quantity, string ImgUrl,
       double ElectRate, string[] ElectTrend) : base(Id, Name, Price, Description, ImgUrl, Quantity)
        {

            this.ElectRate = ElectRate;
            this.ElectTrend = ElectTrend;
        }
        public override double CalcPrice(double tax)
        {
            return Price + ElectRate - tax;
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
