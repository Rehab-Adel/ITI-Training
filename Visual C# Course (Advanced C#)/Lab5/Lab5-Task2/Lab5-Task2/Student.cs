using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Task2
{
    internal class Student
    {
        private string name;
        private int id;
        private byte degrees;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public byte Degrees
        {
            get { return degrees; }
            set
            {
                if (value < 0 || value > 255)
                {
                    throw new ArgumentOutOfRangeException("Degrees should be in the range of 0 to 255");
                }

                degrees = value;
            }
        }

        public void SetDegrees(string degreesString)
        {
            try
            {
                byte degrees = byte.Parse(degreesString);
                Degrees = degrees;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Degrees must be a valid byte value");
            }
        }
    }
}