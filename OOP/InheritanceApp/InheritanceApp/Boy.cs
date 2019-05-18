using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Boy:Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy is playing");
        }

        public void Walk()
        {
            Console.WriteLine("Boy is Walking");
        }
        public void Run()
        {
            Console.WriteLine("Boy is running");
        }

    }
}
