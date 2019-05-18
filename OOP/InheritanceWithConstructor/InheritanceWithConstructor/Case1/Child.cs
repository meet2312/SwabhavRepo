using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructor.Case1
{
    class Child:Parent
    {
        public Child():base()
        {
            Console.WriteLine("Child is invoked");
        }
    }
}
