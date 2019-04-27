using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 4)
            {
                Console.Write("a");
                if (x < 1)
                {
                    Console.Write("");
                }
               
                Console.Write("n");

                if (x > 1)
                {
                    Console.Write("oyster");
                    x = x + 2;
                }
                if (x == 1)
                {
                   
                    Console.Write("noys");
                }
                if (x < 1)
                {
                 
                    Console.Write("oise");
                }
                Console.WriteLine("");
                x = x + 1;
            }
        }
    }
}
