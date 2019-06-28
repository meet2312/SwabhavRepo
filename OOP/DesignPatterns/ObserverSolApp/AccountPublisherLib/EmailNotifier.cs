using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib
{
    public class EmailNotifier : IBalanceChangeNotifier
    {
        public EmailNotifier()
        {

        }
        public void Notify(Account acc)
        {
            Console.WriteLine("Hello " + acc.Emailid + ",balance updated mail been sent ");
        }
    }
}
