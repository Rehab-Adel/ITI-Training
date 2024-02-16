using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task
{
    internal class Parallelogram:Shape
    {
        public Parallelogram()
        {

        }
        public Parallelogram(float m, float n) : base(m, n)
        {
        }

        public override float Area()
        {
            return dimension1 * dimension2;
        }

    }
}
