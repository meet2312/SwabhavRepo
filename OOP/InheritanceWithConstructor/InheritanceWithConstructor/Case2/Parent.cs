using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructor.Case2
{
    class Parent
    {
        public int _foo;

        public Parent(int Foo)
        {
            this._foo = Foo;
            Console.WriteLine("Parent");

        }
        public int GetFoo()
        {
            return _foo;
        }
    }
}
