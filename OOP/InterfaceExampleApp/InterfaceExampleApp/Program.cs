using InterfaceExampleApp.ManBoy;
using InterfaceExampleApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  CaseStudy1();
                CaseStudy2();
        }

        private static void CaseStudy2()
        {
            IMovable[] c = new IMovable[3];
            c[0] = new Car("bmw", "luxury");
            c[1] = new Bike("honda cbr", "classy");
            c[2] = new Truck("tata", "carrier");
            /* var Vehicles = new IMovable[]
             {
                  new Car("",""),new Bike("",""),new Truck("","")
             };
         */
            StartRace(c);
        }

        private static void StartRace(IMovable[] obj)
        {
           
            Console.WriteLine("Race starts");
            
           foreach(IMovable movable in obj)
            {
                movable.Move();
            }

            Console.WriteLine("Race ends");
        }

        private static void CaseStudy1()
        {
            AtTheParty(new Man());
            AtTheParty(new Boy());
            AtTheMovie(new Boy());
        }

        private static void AtTheMovie(IEmotionable obj)
        {
            Console.WriteLine("At the Movie");
            obj.Cry();
            obj.Laugh();
        }

        private static void AtTheParty(IMannerable obj)
        {
            Console.WriteLine("At the Party");
            obj.Wish();
            obj.Depart();
        }
    }
}
