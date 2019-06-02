using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPVIolation
{
    class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Manager starts eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager starts working");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager stops eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager stops working");
        }
    }
}
