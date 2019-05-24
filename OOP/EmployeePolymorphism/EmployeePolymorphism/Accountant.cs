using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    class Accountant:Employee
    {
        double salary;
        public Accountant(int empno, string empname, double empbasicsalary) :base(empno,empname,empbasicsalary)
        {
            this.salary = empbasicsalary;
        }

        public override double CalculateTotalSalary()
        {

            double bonus = (salary * 0.30);

            double total = salary + bonus;
              return total;
           // return "bonus:" + bonus + "total:" + total;
        }

        public override string SplitSalaryDetails()
        {
            double bonus = (salary * 0.30);

            double total = salary + bonus;
           
             return "bonus:" + bonus + " total:" + total;
        }
        public override string EmpRole
        {
            get
            {
                return "Accountant";
            }
        }
    }
}
