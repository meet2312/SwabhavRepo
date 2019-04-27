using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float highest = 0;
            string namest = null;
            Student[] studentdata = new Student[3];
            studentdata[0] = new Student(1, 24, "ABC", 7.5f);
            studentdata[1] = new Student(2, 57, "XVZ", 8.7f);
            studentdata[2] = new Student(3, 18, "QWERT",6.4f);

           foreach(Student student in studentdata)
            {
              //  float st1 = temp.ConvertCgpaToPercentage();
             //   Console.WriteLine(st1);
                Console.WriteLine("Name:{0}", student.GetName());
                Console.WriteLine("Roll No is:{0}", student.GetRollNo());
                Console.WriteLine("Age is:{0}", student.GetAge());
                Console.WriteLine("CGPA is:{0}", student.GetCgpa());
                //float maxper = (Math.Max(st1));
              //  Console.WriteLine("Max Percent is :{0}",Math.Max(st1),)

               if(student.ConvertCgpaToPercentage()>highest)
                {
                    highest = student.ConvertCgpaToPercentage();
                    namest = student.GetName();
                }  
            }
            Console.WriteLine("highest percent is :{0}", highest);
            Console.WriteLine("Name of student:{0}", namest);
        }
    }
}
