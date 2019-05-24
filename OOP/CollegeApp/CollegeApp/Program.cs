using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(11,"andheri","11/02/1994",Student.Branch.Extc);
            Console.WriteLine(student.ToString());
      //      Person student1 = new Student(11, "andheri", "11/02/1994");
            Professor professor = new Professor(15, "dadar", "23/02/1980",300);
            //  Console.WriteLine(professor.ToString());
            Console.WriteLine("id:{0}", professor.Id);
            Console.WriteLine("id:{0}", professor.Address);
            Console.WriteLine("id:{0}", professor.Dob);
            Console.WriteLine("id:{0}", professor.Salary);
            double total = professor.SalaryCalculation();
            Console.WriteLine("total:{0}", total);

        }

        private static void PrintDetails(Person person)
        {
            Console.WriteLine("id:{0}", person.Id);
            Console.WriteLine("address:{0}", person.Address);
            Console.WriteLine("date of birth:{0}", person.Dob);
   
        }
    }
}
