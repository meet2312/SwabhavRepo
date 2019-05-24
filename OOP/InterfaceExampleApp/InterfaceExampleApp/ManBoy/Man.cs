using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp.ManBoy
{
    class Man : IMannerable
    {
        public void Wish()
        {
            Console.WriteLine("Man is wishing hello");
        }

        public void Depart()
        {
            Console.WriteLine("Man is departing goodbye");
        }
    }
}
