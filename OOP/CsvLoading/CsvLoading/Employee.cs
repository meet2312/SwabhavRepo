using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvLoading
{
    class Employee
    {
        private string _managerid;
        private string _empdesignation, _empname, _dateofjoin;
        private string _salary,_commission;
        private int _empid, _deptno;

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

        public string Salary
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

        //private string line;

  /*      public Employee(int empid,string empname,string empdesignation,string managerid,string dateofjoin,string salary,string commission,int deptno)
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
        public Employee()
        {
        }

        //   public Employee(string line)
        //   {

        //     var split = line.Split(',');
        //    _empid = int.Parse(split[0]);
        //   _empname = split[1];
        //  _empdesignation = split[2];
        // _managerid = int.Parse(split[3]);
        // _dateofjoin = split[4];
        // _salary = double.Parse(split[5]);
        // _commission =double.Parse( split[6]);
        // _deptno = int.Parse(split[7]);


        //  }



    }
}
