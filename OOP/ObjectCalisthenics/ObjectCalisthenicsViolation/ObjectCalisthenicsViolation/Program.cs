using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenicsViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            string display = b.board();
            Console.WriteLine(display);

        }
    }
}
