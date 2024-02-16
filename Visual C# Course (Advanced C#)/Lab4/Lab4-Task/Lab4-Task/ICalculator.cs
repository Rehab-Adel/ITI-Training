using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task
{
    internal interface ICalculator
    {
        public void Subtract(int x, int y);
        public void Multiple(int x, int y);
        public void Sum(int x, int y);
        public void Divide(int x, int y);
    }
}
