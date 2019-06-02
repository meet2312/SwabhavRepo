using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution
{
    class Rectangle : IPolygon
    {
        private int _width;
        private int _height;

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public void SetHeight(int height)
        {
            this._height = height;
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public Rectangle(int width, int height)
        {
            this._width = width;
            this._height = height;
        }
        public double CalculateArea()
        {
            double area = _width * _height;
            return area;
        }
    }
}
