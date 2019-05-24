using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHashmapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Student, Student> student = new Dictionary<Student, Student>();
            Student s1 = new Student("meet", 15, 2);
            Student s2 = new Student("priyank",18,4);
            Student s3 = new Student("mano",37,5);
            Student s4 = new Student("zeel", 56, 3);
            student.Add(s1,s1);
            student.Add(s2,s2);
            student.Add(s3,s3);
            student.Add(s4, s4);
            student.Add(s1,s1);
            foreach (KeyValuePair<Student, Student> pair in student)
            {
                Console.WriteLine("KEY: " + pair.Key);
                Console.WriteLine("VALUE: " + pair.Value);
            }
            Console.WriteLine("count:{0}", student.Count);
        }
    }
}
