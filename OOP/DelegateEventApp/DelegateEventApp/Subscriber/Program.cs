using DelegateEventApp.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101,"meet",10000);
            acc1.BalanceChangeEvent += SendEmailNotification;
            acc1.BalanceChangeEvent += SendSMSNotification;
            acc1.Deposit(1000);

        }

        static void SendEmailNotification(Account account)
        {
            Console.WriteLine("Email notification been sent");
        }


        static void SendSMSNotification(Account account)
        {
            Console.WriteLine("SMS notification been sent");
        }

    }
}
