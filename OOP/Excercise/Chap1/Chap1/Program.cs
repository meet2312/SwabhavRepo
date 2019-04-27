using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            while(x>0)
            {
                if(x>2)
                {
                    Console.Write("a");
                }
                x = x - 1;
                Console.Write("-");
                if(x==2)
                {
                    Console.Write("b c");
                }
                if(x==1)
                {
                    Console.Write("d\n");
                    x = x - 1;
                }
            }
        }
    }
}
