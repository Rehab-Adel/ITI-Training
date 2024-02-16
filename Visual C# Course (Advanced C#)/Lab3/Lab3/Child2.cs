using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Child2:Child1
    {
        protected int n2;
        public Child2() : base()
        {
        }

        public Child2(int m, int n, int o, int p) : base(m, n, o)
        {
            n2 = p;
        }

        public override int Sum(int m, int n)
        {
            return base.Sum(m, n);
        }
    }
}
