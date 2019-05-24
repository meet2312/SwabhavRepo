using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    class Programmer:Employee
    {
        double salary;
        public Programmer(int empno, string empname, double empbasicsalary) :base(empno,empname,empbasicsalary)
        {
            this.salary = empbasicsalary;
        }
        public override double CalculateTotalSalary()
        {
           
            double pa = (salary * 0.40);
           
            double total = salary +  pa ;
             return total;

         //   return "pa:" + pa + "total:" + total;
        }

        public override string SplitSalaryDetails()
        {
            double pa = (salary * 0.40);

            double total = salary + pa;
         

           return "pa:" + pa + " total:" + total;
        }
        public override string EmpRole
        {
            get
            {
                return "Programmer";
            }
        }
    }
}
