using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Robot r = new Robot();
            AtWorkStation(m);
            AtWorkStation(r);
            AtCafeteria(m);
        }

        private static void AtCafeteria(IWorkEat w)
        {
            Console.WriteLine("AtCafeteria");
            Console.WriteLine();
            w.StartEat();
            w.StopEat();
        }

        private static void AtWorkStation(IWork w)
        {
            Console.WriteLine("AtWorkStation");
            Console.WriteLine();
            w.StartWork();
            w.StopWork();
        }
    }
}
