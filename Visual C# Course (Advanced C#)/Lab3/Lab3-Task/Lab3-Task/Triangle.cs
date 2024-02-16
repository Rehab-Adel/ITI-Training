using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task
{
    internal class Triangle:Shape
    {
        public Triangle()
        { }
        public Triangle(float h, float b) : base(h, b)
        {
        }
        public override float Area()
        {
            return (dimension1 * dimension2) * 0.5f;
        }
    }
}
