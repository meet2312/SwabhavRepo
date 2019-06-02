using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(new DBLogger());
           // TaxCalculator calc1 = new TaxCalculator(new FileLogger());
            //  Console.WriteLine("{0}",calc.Calculate(10, 5));
            Console.WriteLine("{0}", calc.Calculate(10, 0));
           // Console.WriteLine("{0}", calc1.Calculate(0, 20));
        }
    }
}
