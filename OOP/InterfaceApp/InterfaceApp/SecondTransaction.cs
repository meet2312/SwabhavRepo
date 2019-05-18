using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
   public  class SecondTransaction:Transactions,ITransactions
    {
        public SecondTransaction(string tCode, string date, double amount) : base(tCode, date, amount)
        {
        }

        public override void Foo()
        {
            Console.WriteLine("this is second foo");
        }
    }
}
