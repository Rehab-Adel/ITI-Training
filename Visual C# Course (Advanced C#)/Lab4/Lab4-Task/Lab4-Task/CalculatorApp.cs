using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task
{
    internal class CalculatorApp
    {
        public static void Run()
        {
            Console.Write("Enter First Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int y = int.Parse(Console.ReadLine());

            Calculation calc = new Calculation(x, y);
            PerformCalculation(calc);

            calc.Print();
        }

        private static void PerformCalculation(Calculation calc)
        {
            calc.Statements();
            int choice = int.Parse(Console.ReadLine());
            calc.Calculate(choice);
        }
    }
}
