using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new SavingsAccount(11, "abc", 2000);
            Account acc2 = new CurrentAccount(12, "xyz", 3000);
            PrintDetails(acc1);
            acc1.Deposit(100);
            PrintDetails(acc1);
            acc1.Withdraw(200);
            PrintDetails(acc1);
            PrintDetails(acc2);
            acc2.Deposit(100);
            PrintDetails(acc2);
            acc2.Withdraw(5000);
            PrintDetails(acc2);

        }

        private static void PrintDetails(Account acc)
        {
            Console.WriteLine("Acc no:{0}", acc.Accno);
            Console.WriteLine("Name:{0}", acc.Accname);
            Console.WriteLine("Balance:{0}", acc.Balance);
        }
    }
}
