using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructor.Case2
{
    class Child:Parent
    {
        public Child():base(100)
        {
            Console.WriteLine("Child");
        }
        public Child(int foo):base(foo)
        {
            Console.WriteLine("Child");
        }
    }
}
