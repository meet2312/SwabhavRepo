using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPVIolation
{
    class Robot : IWorker
    {
        public void StartEat()
        {
            throw new NotImplementedException();
        }

        public void StartWork()
        {
            Console.WriteLine("Robot starts working");
        }

        public void StopEat()
        {
            throw new NotImplementedException();
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stops working");
        }
    }
}
