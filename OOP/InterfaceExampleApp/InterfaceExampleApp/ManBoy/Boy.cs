using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp.ManBoy
{
    class Boy : IEmotionable, IMannerable
    {
        public void Cry()
        {
            Console.WriteLine("Boy is crying");
        }
        public void Laugh()
        {
            Console.WriteLine("Boy is laughing");
        }

        public void Wish()
        {
            Console.WriteLine("Boy is wishing hello");
        }

        public void Depart()
        {
            Console.WriteLine("Boy is  departing goodbye");
        }



    }
}
