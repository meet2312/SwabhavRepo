using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Case1.Child();
            Case2.Child c1 =new Case2.Child();
            Console.WriteLine(c1.GetFoo());
            Case2.Child c2 = new Case2.Child();
            Console.WriteLine(c1.GetFoo());
            Case2.Child c3 = new Case2.Child(300);
            Console.WriteLine(c3.GetFoo());
        }
    }
}
