using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("meet",500);
            Customer c2 = new Customer("sachin", 200);
       //     Console.WriteLine("Id is:{0}", c2.Id);
      //      Console.WriteLine("Id is:{0}", c1.Id);
            PrintDetails(c2);
            Console.WriteLine("");
            PrintDetails(c1);
           
         

        }

        private static void PrintDetails(Customer customer)
        {
            Console.WriteLine("Name :{0}", customer.Name);
            Console.WriteLine("Id:{0}", customer.Id);
            Console.WriteLine("OrderCount:{0}", customer.OrderCount);
        }
    }
}
