using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution
{
    class Square : IPolygon
    {
        private int _side;
        public Square(int side)
        {

        }
        public double CalculateArea()
        {
            double area = _side * _side;
            return area;
        }
    }
}
