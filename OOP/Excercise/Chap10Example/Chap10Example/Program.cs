using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 20456;
            double two = 100567890.248907;
            string s = string.Format("rank is:{0} out of :{1}", one, two);
            Console.Write(s);
            Console.Write("sqrt is :{0}", Math.Sqrt(2));
        }
    }
}
