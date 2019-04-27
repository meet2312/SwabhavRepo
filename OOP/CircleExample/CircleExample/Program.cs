using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.GetPerimeter();
            c.GetArea();
            Console.WriteLine("Perimeter is :{0}",c.GetPerimeter());
            Console.WriteLine("Area is :{0}", c.GetArea());
        }
    }
}
