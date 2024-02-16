using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculate<T>
    {
        public static void Swap(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;


        }
    }
}
