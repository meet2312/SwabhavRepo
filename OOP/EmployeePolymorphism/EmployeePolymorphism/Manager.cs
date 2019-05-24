using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    class Manager:Employee
    {
        private double salary;
        public Manager(int empno, string empname, double empbasicsalary) :base(empno,empname,empbasicsalary)
        {
            this.salary = empbasicsalary;
        }
        public override double CalculateTotalSalary()
        {
            double hra = (salary * 0.50);
            double ta = (salary * 0.40);
            double da = (salary * 0.30);
            double total = salary + hra + ta + da;
            return total;
         //  return "hra:" + hra+ "ta:" + ta + "da:" + da + "total:" + total;
        }

        public override string SplitSalaryDetails()
        {
            double hra = (salary * 0.50);
            double ta = (salary * 0.40);
            double da = (salary * 0.30);
            double total = salary + hra + ta + da;
           
            return "hra:" + hra+ " ta:" + ta + " da:" + da + " total:" + total;
        }
        public override string EmpRole
        {
            get
            {
                return "Manager"; 
            }
        }
    }
}
