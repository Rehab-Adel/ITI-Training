using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task
{
    internal class GeoShape
    {
        public float TotalAreas(Shape[] shapes)
        {
            float SumOfAReas = 0;
            for(int i = 0; i< shapes.Length; i++)
            {
                SumOfAReas += shapes[i].Area();
            }
            return SumOfAReas;
        }
    }
}
