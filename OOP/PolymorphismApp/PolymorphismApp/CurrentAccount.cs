using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int accno, string accname, double balance) : base(accno, accname, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            
            double balancetoupdate = 0;
    
            balancetoupdate = _balance - amount;
            if (balancetoupdate > Constant.overdraft)
            {
                _balance = balancetoupdate;
               
            }
            else Console.WriteLine("Cannot be possible");

        }
    }
}
