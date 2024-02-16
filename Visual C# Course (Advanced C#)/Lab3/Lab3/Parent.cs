using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Parent
    {
        protected int x;
        protected int y;

        public Parent()
        {
            x = 0;
        }

        public Parent(int m, int n)
        {
            x = m;
            y = n;
        }

        public void SetX(int m)
        {
            x = m;
        }
        public void SetY(int n)
        {
            y = n;
        }

        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }

        public virtual int Sum(int m, int n)
        {
            return m + n;
        }
    }
}
