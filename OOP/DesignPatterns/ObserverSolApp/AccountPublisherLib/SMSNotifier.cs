using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib
{
    public class SMSNotifier : IBalanceChangeNotifier
    {
        public SMSNotifier()
        {

        }
        public void Notify(Account acc)
        {
            Console.WriteLine("Hello " + acc.Mobileno + ",balance updated sms been sent ");
        }
    }
}
