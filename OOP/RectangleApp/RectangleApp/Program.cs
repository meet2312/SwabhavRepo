using RectangleApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle  small = new Rectangle();
            small.width = 30;
            small.height = 10;
            Console.WriteLine("For small rectangle");
            Console.WriteLine("width is:{0}", small.width);
            Console.WriteLine("height is:{0}", small.height);
            Console.WriteLine(small);
            small.CalculateArea();
            Console.WriteLine("Area is:{0}", small.CalculateArea());

             Rectangle big = new Rectangle();
             big.width = 50;
             big.height = 20;
             Console.WriteLine("For big rectangle");
             Console.WriteLine("width is:{0}", big.width);
             Console.WriteLine("height is:{0}", big.height);
             big.CalculateArea();
             Console.WriteLine("Area is:{0}", big.CalculateArea());



        }
    }
}
