using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap9Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = 8;
            float density = 2.3F;
            string name = "Swabhav";
            long[] feathers = { 1, 2, 3, 4, 5, 6 };
            bool canFly = true;
            int airspeed = 45;

            Duck[] d = new Duck[7];

            d[0]= new Duck();
            d[1]= new Duck(density, weight);
            d[2] = new Duck(name, feathers);
            d[3] = new Duck(canFly);
            d[4] = new Duck(3.3f,airspeed);
            d[5]= new Duck(false);
            d[6] = new Duck(airspeed,density);
          


        }
    }
}
