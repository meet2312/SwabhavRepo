using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Account acc1 = new Account(111,"qwerty",5000);
            Account ac1 = new Account(111,"ssss",2000);
            Account ac2 = new Account(111,"ssss",2000);

            //     ac1.Accno = 111;
            //     ac1.Name = "azxx";
            //     ac1.Balance = 2200;
         
            Console.WriteLine(ac1.ToString());
            Console.WriteLine(ac1);
            Console.WriteLine();

            //       Console.WriteLine(ac1 == ac1);
            //       Console.WriteLine(ac1.GetHashCode());
            //       Console.WriteLine(ac2.GetHashCode());
            //       Console.WriteLine(ac1 == ac2);
            //     Console.WriteLine(ac1.ToString().Equals(ac2.ToString()));
            //       Console.WriteLine(ac1.Equals(ac2));
        }
    }
}
