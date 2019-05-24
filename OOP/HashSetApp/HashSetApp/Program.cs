using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> student = new HashSet<Student>();
            student.Add(new Student("meet", 24));
            student.Add(new Student("priyank", 23));
            student.Add(new Student("pankil", 22));
            student.Add(new Student("mayur", 25));
            student.Add(new Student("meet", 24));
            foreach (Student s in student)
            {
                Console.WriteLine(s);
                Console.WriteLine();

            }

        }
    }
}
