using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            try
            {
                long res=c.Add(-90, 770);
                Console.WriteLine("Addition is:{0}", res);
            }
            catch (NegativeNumberNotSupportedException e)
            { 
                Console.WriteLine("Exception:{0}",e.Message);
            }
        }
    }
}
