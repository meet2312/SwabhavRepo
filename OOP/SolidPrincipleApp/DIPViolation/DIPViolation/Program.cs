using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(TaxCalculator.LogType.DB);
          //  Console.WriteLine("{0}",calc.Calculate(10, 5));
            Console.WriteLine("{0}", calc.Calculate(10, 0));
        }
    }
}
