using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib
{
    public class Account
    {
        private int _accountno;
        private string _name;
        private double _balance;
        private string _emailid;
        private double _mobileno;
        private List<IBalanceChangeNotifier> subscriber = new List<IBalanceChangeNotifier>();


        public Account(int accountno, string name, double balance, string emailid, double mobileno)
        {
            this._accountno = accountno;
            this._name = name;
            this._balance = balance;
            this._emailid = emailid;
            this._mobileno = mobileno;
        }

        public void Withdraw(double amount)
        {
            double updatedbalance = _balance - amount;
            notifyObservers();
        }

        private void notifyObservers()
        {
            foreach (var notifier in subscriber)
            {
                notifier.Notify(this);
            }
        }

        public void Deposit(double amount)
        {
            double updatedbalance = _balance + amount;
        }

        public void RegisterNotifier(IBalanceChangeNotifier notifier)
        {
            subscriber.Add(notifier);
        }

        public int Accountno
        {
            get
            {
                return _accountno;
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

        public string Emailid
        {
            get
            {
                return _emailid;
            }

        }

        public double Mobileno
        {
            get
            {
                return _mobileno;
            }

         
        }

       
    }
}
