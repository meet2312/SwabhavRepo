using FactoryLibClient;
using SimpleFactoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMobileFactory factory = AutoMobileFactory.GetInstance();

            //AutoMobileFactory factory = new AutoMobileFactory();
            IAutoMobile auto = factory.Make(AutoType.BMW);

            Console.WriteLine(auto.GetType());
            auto.Start();
            auto.Stop();
        }
    }
}
