using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryClient
{
    internal class BMW : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("BMW starts");
        }

        public void Stop()
        {
            Console.WriteLine("BMW stops");
        }
    }
}
