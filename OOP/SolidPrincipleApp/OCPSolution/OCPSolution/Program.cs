using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixdep = new FixedDeposit("meet",100000,10,new DiwaliRate());
            Console.WriteLine("SImple Interest:{0}", fixdep.CalculateSimpleInterest());
        }
    }
}
