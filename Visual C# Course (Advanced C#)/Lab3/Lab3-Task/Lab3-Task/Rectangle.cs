using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task
{
    internal class Rectangle:Shape
    {
        public Rectangle()
        { }
        public Rectangle(float a, float b) : base(a, b)
        {
        }
        public override float Area()
        {
            return (dimension1 * dimension2);
        }
    }
}
