using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FashionProduct : Product
    {
        public double fashionRate { get; set; }
        public string[] fashionTrend { get; set; }
        public FashionProduct() : base()
        {
            fashionRate = 0.0;
        }
        public FashionProduct(int id, string name, int price, string[] bestsalers, string description, int quantity, double rate, double fashionRate, string[] fashionTrend):base( id,  name,  price, bestsalers,  description,  quantity, rate)
        {
            this.fashionRate = fashionRate;
            this.fashionTrend = fashionTrend;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"the fashionRate products is  {fashionRate}");
            if (fashionTrend == null)
            {
                Console.WriteLine("fashion array is empty");
            }
            else
            {
                foreach (string item in fashionTrend)
                {
                    Console.Write( item  + " ");
                }
            }

        }

    }
}
