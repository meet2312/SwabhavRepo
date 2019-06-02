using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoMobileFactory fact = BMWFactory.GetInstance();
            IAutoMobile auto = fact.Make();
            auto.Start();
            auto.Stop();
        }
    }
}
