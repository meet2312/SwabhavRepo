using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Transactions t1 = new Transactions("001", "8/10/2012", 78900.00);
            SecondTransaction st1 = new SecondTransaction("001", "8/10/2012", 78900.00);
            Transactions t2 = new Transactions("002", "9/10/2012", 451900.00);
            ITransactions it = t1;

            ITTransaction it1 = st1;
          //  it.showTransaction();
      //      it.getAmount();
       //     it.showDetails1();
      //      it.showDetails();
            it.Foo();
     //       it1.showTransaction();
     //       it1.getAmount();
     //       it1.showDetails();
     //       it1.showDetails1();
            it1.Foo();
           // t1.showTransaction();
           // t2.showTransaction();
     
        }
    }
}
