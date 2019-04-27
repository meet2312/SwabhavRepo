
using RectangleEncapsulation.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.SetWidth(90);
            small.SetHeight(10);
            small.CalculateArea();
            Console.WriteLine("For small rectangle");
            Console.WriteLine("width is:{0}", small.GetWidth());
            Console.WriteLine("height is:{0}", small.GetHeight());
            Console.WriteLine("Area is:{0}", small.CalculateArea());
            Rectangle big = new Rectangle();
            big.SetWidth(50);
            big.SetHeight(20);
            big.CalculateArea();
            Console.WriteLine("For big rectangle");
            Console.WriteLine("width is:{0}", big.GetWidth());
            Console.WriteLine("height is:{0}", big.GetHeight());
            Console.WriteLine("Area is:{0}", big.CalculateArea());
        }
    }


}
