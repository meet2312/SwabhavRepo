using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
  public abstract class Employee
    {
        private int _empno;
        private string _empname;
        private double _empbasicsalary;
        private string _emprole;

        public Employee(int empno,string empname,double empbasicsalary)
        {
            this._empno = empno;
            this._empname = empname;
            this._empbasicsalary = empbasicsalary;
        }

        public abstract double CalculateTotalSalary();

        public abstract string SplitSalaryDetails();

        public int Empno
        {
            get
            {
                return _empno;
            }
        }
        public string Empname
        {
            get
            {
                return _empname;
            }
        }
        public double Empbasicsalary
        {
            get
            {
                return _empbasicsalary;
            }
        }
        public abstract string EmpRole
        {
            get;
        }
      
       
    }
}
