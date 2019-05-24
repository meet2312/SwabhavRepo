using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Business
{
    class Account
    {
  
        private int _accno;
        private string _name;
        private double _balance;
     
        public Account(int accno,string name,double balance)
        {
            this._accno = accno;
            this._name = name;
            this._balance = balance;
        }

        public Account(int acc_no,string name1)
        {
            this._accno = acc_no;
            this._name = name1;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Details(Account _a)
        {
            Console.WriteLine("acc:{0}", _a._accno);
            Console.WriteLine("acc _name:{0}", _a._name);
            Console.WriteLine("acc_balance:{0}", _a._balance);
        }
        
        public void Withdraw(double amount)
        {
         
            double balancetoupdate = 0;
            balancetoupdate = _balance - amount;
        
            if (balancetoupdate > 500)
            {
                Console.WriteLine("Balance after Withdraw");
                _balance = balancetoupdate;
             

            }
            else
            {
                throw new InsufficientFundsException(this);
                // throw new InsufficientFundsException("InsufficientFundsException");
                //throw new InsufficientFundsException(_accno,_name,_balance);
                // throw new InsufficientFundsException("Minimum balance should be 500");
            }
         //   else Console.WriteLine("Cannot be possible");
           
        }

        public int Accno
        {
            get
            {
                return _accno;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }
     
    }
}
