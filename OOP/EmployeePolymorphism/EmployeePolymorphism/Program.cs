using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager(1,"qwerty",15000);
            PrintSalarySlip(manager);
            Console.WriteLine("");
            Employee programmer = new Programmer(2, "qazxsw", 25000);
            PrintSalarySlip(programmer);
            Console.WriteLine("");
            Employee accountant = new Accountant(3, "plkmijn", 10000);
            PrintSalarySlip(accountant);

        }

        public static void PrintSalarySlip(Employee employee)
        {

            Console.WriteLine("Role of employee:{0}", employee.EmpRole);
        //    Console.WriteLine("Role of employee:{0}",employee.GetType().Name);
            Console.WriteLine("Name :{0}", employee.Empname);
            Console.WriteLine("basic salary is :{0}", employee.Empbasicsalary);
            Console.WriteLine("total salary is :{0}",employee.CalculateTotalSalary());
            Console.WriteLine("split salary is :{0}", employee.SplitSalaryDetails());
        }
    }
}
