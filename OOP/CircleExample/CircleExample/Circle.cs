using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExample
{
    class Circle
    {
        private float radius;
        private string colour;
       

        public double GetPerimeter()
        {
            double perimeter = 2 * Math.Round(Math.PI) * radius;
            return perimeter;
        }

        public double GetArea()
        {
            double area = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            return area;
        }
    }

   
}
