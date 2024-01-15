using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal abstract class Product
    {
        public string Name { get; set; }

        public int id { get; set; }

        public int Price { get; set; }

        public string ImgUrl { get; set; }


        public string Description { get; set; }

        public double Quantity { get; set; }


        public Product()
        {
            Price = 0;
            id = 0;
        }

        public Product(int Id, string Name, int Price, string Description, string ImgUrl, double Quantity)
        {
            this.id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.ImgUrl = ImgUrl;
            this.Quantity = Quantity;
        }

        abstract public double CalcPrice(double tax);

        public virtual void ShowType()
        {
            Console.WriteLine("The Product");
        }
    }
}
