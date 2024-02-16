using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task
{
    internal class Calculation : Parameter_List, ICalculator, IChecker
    {
        public Calculation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Statements()
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Subtract");
            Console.WriteLine("2. Multiple");
            Console.WriteLine("3. Sum");
            Console.WriteLine("4. Divide");
        }
        public void Subtract(int x, int y)
        {
            result = x - y;
        }

        public void Multiple(int x, int y)
        {
            result = x * y;
        }

        public void Sum(int x, int y)
        {
            result = x + y;
        }

        public void Divide(int x, int y)
        {
            result = x / y;
        }

        public bool Check(int x, int y)
        {
            return x != 0 && y != 0;
        }

        public override void Print()
        {
            Console.WriteLine($"The result is {result}");
        }

        public void Calculate(int choice)
        {
            switch (choice)
            {
                case 1:
                    Subtract(x, y);
                    break;
                case 2:
                    Multiple(x, y);
                    break;
                case 3:
                    Sum(x, y);
                    break;
                case 4:
                    Divide(x, y);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
    }
}
