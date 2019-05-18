using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingApp
{
    class Account 
    {
        private int _accno;
        private string _name;
        private double _balance;


        public Account(int accno, string name, double balance)
        {
            this._accno = accno;
            this._name = name;
            this._balance = balance;
        }

        public Account(int acc_no, string name1)
        {
            this._accno = acc_no;
            this._name = name1;
        }
        public Account():base()
        {
          
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }


        public void Withdraw(double amount)
        {
            double balancetoupdate = 0;
            balancetoupdate = _balance - amount;
            //  Console.WriteLine(amount);
            if (balancetoupdate > 500)
            {
                _balance = balancetoupdate;
                // Console.WriteLine(_balance);
            }
            else Console.WriteLine("Cannot be possible");

        }

        public int Accno
        {
            get
            {
                return _accno;
            }
            set
            {
                _accno = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        
      /*   public override string ToString()
        {
          
          Console.WriteLine("override");
          return "Acc:"+"acc no:"+ _accno + "Name:" + _name + "Balance:" + _balance;   
                   // return string.Format("My acc no is:{0}"+_accno+"Name is:{0}"+_name+"bal is:{0}"+_balance);
        }

      */

        /*      public override Boolean Equals(Object o)
              {
                  return true;
                  // return string.Format("My acc no is:{0}"+_accno+"Name is:{0}"+_name+"bal is:{0}"+_balance);
              }

          }
          */
    }

}
