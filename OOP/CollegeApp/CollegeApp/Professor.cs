using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Professor:Person,SalaryEmployee
    {
        private double _salary;

        public Professor(int _id, string _address, string _dob,double salary):base(_id,_address,_dob)
        {
            this._salary = salary;
        }

        public double SalaryCalculation()
        {
           double Salary = _salary * 1000;
            return Salary;
           
        }

        public double Salary
        {
            get
            {
                return _salary;
            }
        }

       
    }
}
