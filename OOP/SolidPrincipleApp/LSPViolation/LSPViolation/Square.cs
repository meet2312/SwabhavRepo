using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolation
{
    class Square : Rectangle
    {
       // private int _side;
        public Square(int side) : base(side, side)
        {
            this.Width = this.Height = side;
            //this._side = side;
        }

        public override void SetWidth(int width)
        {
            this.Width = this.Height = width;
            //this._side = width;
        }
        public override void SetHeight(int height)
        {
            this.Width = this.Height = height;
            // this._side = height;
        }
       
    }
}
