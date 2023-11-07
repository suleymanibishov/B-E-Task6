using System;

namespace B_E_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int i in st.Grades)
            {
                Console.WriteLine(i);
            }
        }
    }
}
