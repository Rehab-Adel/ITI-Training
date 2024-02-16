using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class String<S>
    {
        public S x { get; set; }
        public S y { get; set; }

        public String(S a, S b)
        {
            x = a; y = b;
        }
        public String() { }
        public override string ToString()
        {
            return ("X= " + x.ToString() + ", Y= " + y.ToString());
        }
    }
}
