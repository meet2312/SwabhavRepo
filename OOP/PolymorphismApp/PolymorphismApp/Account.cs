using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
   public abstract class Account
    {
        private int _accno;
        private string _accname;
        protected double _balance;

        public Account(int accno,string accname,double balance)
        {
            this._accno = accno;
            this._accname = accname;
            this._balance = balance;
        }

        public int Accno
        {
            get
            {
                return _accno;
            }
        }

        public string Accname
        {
            get
            {
                return _accname;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }
     
        public abstract void Withdraw(double amount);
        
    }

     static class Constant
    {
       public const double minbalance = 500;
        public const double overdraft = -5000;
    }
}
