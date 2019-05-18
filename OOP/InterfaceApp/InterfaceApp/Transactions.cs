using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
  public  class Transactions:ITransactions,ITTransaction
    {
        private string _tCode;
        private string _date;
        private double _amount;

        public Transactions()
        {
            _tCode = " ";
            _date = " ";
            _amount = 0.0;
        }
        public Transactions(string tCode, string date, double amount)
        {
            _tCode = tCode;
            _date = date;
            _amount = amount;
        }
        public double getAmount()
        {
            return _amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", _tCode);
            Console.WriteLine("Date: {0}", _date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
        public void showDetails()
        {
            Console.WriteLine("qwerty");
        }
        public void showDetails1()
        {
            Console.WriteLine("dbjdkbkd");
        }
        public virtual void Foo()
        {
            Console.WriteLine("this is first fooooo");
        }
    }
}
