using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Child1:Parent
    {
        protected int z;
        public Child1() : base()
        {
        }

        public Child1(int m, int n, int o) : base(m, n)
        {
            z = o;
        }

        
        public void SetZ(int p)
        {
            y = p;
        }

        public int GetZ()
        {
            return y;
        }
        public override int Sum(int m, int n)
        {
            return base.Sum(m, n);
                //m+n+z
        }
    }
}
