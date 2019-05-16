using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
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

        public Account()
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
