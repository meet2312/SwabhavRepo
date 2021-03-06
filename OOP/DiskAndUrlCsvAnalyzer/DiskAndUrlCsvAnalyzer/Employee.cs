﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskAndUrlCsvAnalyzer

{
    class Employee : IEquatable<Employee>
    {
        private int _empid, _deptno, _salary;
        private string _empname, _empdesignation, _dateofjoin, _managerid, _commission;

        public int Empid
        {
            get
            {
                return _empid;
            }

            set
            {
                _empid = value;
            }
        }

        public string Empname
        {
            get
            {
                return _empname;
            }

            set
            {
                _empname = value;
            }
        }

        public string Empdesignation
        {
            get
            {
                return _empdesignation;
            }

            set
            {
                _empdesignation = value;
            }
        }
        public string Dateofjoin
        {
            get
            {
                return _dateofjoin;
            }

            set
            {
                _dateofjoin = value;
            }
        }
        public string Managerid
        {
            get
            {
                return _managerid;
            }

            set
            {
                _managerid = value;
            }
        }

        public int Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                _salary = value;
            }
        }


        public string Commission
        {
            get
            {
                return _commission;
            }

            set
            {
                _commission = value;
            }
        }


        public int Deptno
        {
            get
            {
                return _deptno;
            }

            set
            {
                _deptno = value;
            }
        }


        public bool Equals(Employee other)
        {
            return this._empid.Equals(other._empid);
        }
        public override int GetHashCode()
        {
            return this._empid.GetHashCode();
        }
    }

}




/* public Employee(int empid,string empname,string empdesignation,int managerid,string dateofjoin,double salary,double commission,int deptno)
 {
     this._empid = empid;
     this._empname = empname;
     this._empdesignation = empdesignation;
     this._managerid = managerid;
     this._dateofjoin = dateofjoin;
     this._salary = salary;
     this._commission = commission;
     this._deptno = deptno;
 }
  */
