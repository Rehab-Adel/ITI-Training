using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Lab4
{
    public class Student
    {
        public string Name { get; set; }
        private List<int> grades;

        public Student(int numberOfGrades)
        {
            grades = new List<int>(Enumerable.Repeat(0, numberOfGrades));
        }

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < grades.Count)
                {
                    grades[index] = value;
                }
            }
            get
            {
                if (index >= 0 && index < grades.Count)
                {
                    return grades[index];
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
