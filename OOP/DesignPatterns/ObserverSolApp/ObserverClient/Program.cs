using AccountPublisherLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, "meet", 5000, "meetjhaveri2312@gmail.com", 9090909090);
            account.RegisterNotifier(new EmailNotifier());
            account.RegisterNotifier(new SMSNotifier());
            account.Withdraw(100);
            
            
        }
    }
}
