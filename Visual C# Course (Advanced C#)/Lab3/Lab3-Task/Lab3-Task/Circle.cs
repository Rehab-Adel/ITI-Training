using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task
{
    internal class Circle:Shape
    {
        public Circle()
        {}
        public Circle(float r):base(r)
        {
        }
        public override float Area()
        {
            return (dimension1 * dimension2) * 3.14f;
        }
    }
}
