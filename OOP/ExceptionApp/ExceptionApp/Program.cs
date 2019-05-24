using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1 = Int32.Parse(args[0]);
            int no2 = Int32.Parse(args[1]);
            int y = no1 / no2;
            Console.WriteLine(y);
            Main(args);
            
        }
    }
}
