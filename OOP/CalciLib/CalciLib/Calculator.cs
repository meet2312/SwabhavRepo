using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalciLib
{
    public  class Calculator
    {
        public long Add(long number1, long number2)
        {
            if (number1 > 0 && number2 > 0)
            {
                long res = number1 + number2;
                return res;
            }
            else
            {
                throw (new NegativeNumberNotSupportedException("NegativeNumberNotSupportedException"));
            }
           
        }
    }
}
