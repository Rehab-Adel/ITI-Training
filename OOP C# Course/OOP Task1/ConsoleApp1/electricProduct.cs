using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ElectricProduct :Product
    {
        public double electricRate { get; set; }
        public string[] electricTrend { get; set; }
        public ElectricProduct() : base()
        {
            electricRate = 0.0;
        }
        public ElectricProduct(int id, string name, int price, string[] bestsalers, string description, int quantity, double rate, double electricRate, string[] electricTrend) : base(id, name, price, bestsalers, description, quantity, rate)
        {
            this.electricRate = electricRate;
            this.electricTrend = electricTrend;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"the electricRate  is  {electricRate}");
            if (electricTrend == null)
            {
                Console.WriteLine("electricTrend array is empty");
            }
            else
            {
                foreach (string item in electricTrend)
                {
                    Console.Write(item + " ");
                }
            }

        }

    }
}
