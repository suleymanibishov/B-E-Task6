using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task6
{
    class Student
    {
        public string FullName { get; set; }
        public string Class { get; set; }
        int[] grades;
        public int[] Grades { get => grades; 
            set {
                int index = 0;
                foreach (int i in value)
                {
                    if (i % 2 == 0)
                    {
                        index++;
                    }
                }
                grades = new int[index];
                index = 0;
                foreach (int i in value)
                {
                    if (i % 2 == 0)
                    {
                        grades[index++] = i;
                    }
                }
            } 
        }
    }
}
