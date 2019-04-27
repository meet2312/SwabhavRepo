using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulation.Business
{
    public class Rectangle
    {
        private int width;
        private int height;

        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int width)
        {
              if (width < 0)
              {
                  this.width = 1;
              }
              else if (width > 0 && width <= 100)
              {
                  this.width = width;
              }
               else this.width = 100; 
        }
      
        public int GetHeight()
        {
            return height;
        }
        public void SetHeight(int height)
        {
              if (height < 0)
              {
                  this.height = 1;
              }
              else if (height > 0 && height <= 100)
              {
                  this.height = height;
              }
              else this.height = 100;    
        }

        public int CalculateArea()
        {
            int area = width * height;
            return area;
        }
    }
}
