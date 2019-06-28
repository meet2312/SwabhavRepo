using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventApp.Publisher
{
    delegate void DBalanceChange(Account account);
    class Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        public event DBalanceChange BalanceChangeEvent;

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

        public Account(int accno,string name,double balance)
        {
            this._accno = accno;
            this._name = name;
            this._balance = balance;
        }

        public void Deposit(double amount)
        {
            double finalbalance = _balance + amount;
            if(BalanceChangeEvent != null)
            {
                BalanceChangeEvent(this);
            }

        }

    }

    
}
