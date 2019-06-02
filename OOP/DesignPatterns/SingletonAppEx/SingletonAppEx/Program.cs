using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAppEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // DataService service1 = new DataService();
            //    DataService service2 = new DataService();
            //   service1.DoSomething();
            //   service2.DoSomething();
            //    Console.WriteLine(service1.GetHashCode());
            //    Console.WriteLine(service2.GetHashCode());

            DataService service1 = DataService.GetInstance();

            DataService service2 = DataService.GetInstance();

            Console.WriteLine(service1.GetHashCode());
            Console.WriteLine(service2.GetHashCode());

            service1.DoSomething();
            service2.DoSomething();

        }
    }
}
