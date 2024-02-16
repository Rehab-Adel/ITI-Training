using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task
{
    internal abstract class Shape
    {
        protected float dimension1;
        protected float dimension2;

        public Shape()
        {
            dimension1 = dimension2 = 0;
        }
        public Shape(float dim)
        {
            dimension1 = dimension2 = dim;
        }
        public Shape (float dim1, float dim2)
        {
            dimension1 = dim1;
            dimension2 = dim2;
        }

        public void SetDimension1(float dims1)
        {
            dimension1 = dims1;
        }
        public float GetDimension1()
        {
            return dimension1;
        }

        public void SetDimension2(float dims2)
        {
            dimension2 = dims2;
        }
        public float GetDimension2()
        {
            return dimension2;
        }

        public abstract float Area();

    }
}
