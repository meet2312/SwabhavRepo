using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolation
{
    class Rectangle
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


        public virtual void SetWidth(int width)
        {
            this._width = width;
        }
        public virtual void SetHeight(int height)
        {
            this._height = height;
        }
        public Rectangle(int width,int height)
        {
            this._width = width;
            this._height = height;
        }

        public float CalculateArea()
        {
            float area = _width * _height;
            return area;
        }
    }
}
