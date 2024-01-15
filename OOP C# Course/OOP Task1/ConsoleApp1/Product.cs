using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string[] bestsalers { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public double  rate { get; set; }

        public Product()
        {
            id = 0;
            name = "";
            price = 0;
            //The array is declared but not initialized, so it is assigned the default value (null)
            description = "";
            quantity = 0;
        }
        public Product(int id , string name, int price , string[] bestsalers, string description , int quantity ,double rate)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.bestsalers = bestsalers;
            this.description = description;
            this.quantity =quantity;
            this.rate = rate;

        }
        public Product(int id, string name, int price) : this(id, name, price, null , "", 0,0.0)
        {


        }
        public virtual void Print()
        {
            Console.WriteLine($"id of the product is  {id}");
            Console.WriteLine($"name of the product is {name}");
            Console.WriteLine($"price of the product is {price}");
            if (bestsalers == null)
            {
                Console.WriteLine("this array is empty");
            }
            else
            {
                foreach (var item in bestsalers)
                {
                    Console.Write( item +" ");
                  
                }
            }
            Console.WriteLine();
            Console.WriteLine($"description of the product is {description}");
            Console.WriteLine($"quantity of the product is {quantity}");
            Console.WriteLine($"rate of the product is {rate}");


        }

    }
}

