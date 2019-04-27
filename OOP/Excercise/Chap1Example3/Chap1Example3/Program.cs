using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            while(x<5)
            {
                y = x - y;
                y = y + x;
                y = y + 2;
                if(y>4)
                {
                    y = y - 1;
                }
               // x = x + 1;
             //   y = y + x;
                if(y<5)
                {
                    x = x + 1;
                    if(y<3)
                    {
                        x = x - 1;
                    }
                }
                y=y+2;
                Console.WriteLine(x + "" + y + "");
                x = x + 1;
            }
        }
    }
}
