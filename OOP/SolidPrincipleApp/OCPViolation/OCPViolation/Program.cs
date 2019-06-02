using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd = new FixedDeposit("meet",100000,10,FestivalType.NORMAL);
            Console.WriteLine("Simple Interest :{0}",fd.CalculateSimpleInterest());
        }
    }
}
