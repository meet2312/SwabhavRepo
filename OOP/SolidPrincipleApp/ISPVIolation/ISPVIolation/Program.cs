using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPVIolation
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
            AtCafeteria(r);   // Liskov substitution violation
        }

        private static void AtCafeteria(IWorker w)
        {
            Console.WriteLine("AtCafeteria");
            Console.WriteLine();
            w.StartEat();
            w.StopEat();
        }

        private static void AtWorkStation(IWorker w)
        {
            Console.WriteLine("AtWorkStation");
            Console.WriteLine();
            w.StartWork();
            w.StopWork();
        }
    }
}
