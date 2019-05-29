using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalciLib
{
    public  class NegativeNumberNotSupportedException:Exception
    {
        private string _message;
        public NegativeNumberNotSupportedException()
        {

           // Console.WriteLine("NegativeNumberNotSupportedException");
        }

       public NegativeNumberNotSupportedException(string message)
        {
            _message = message;
           // Console.WriteLine("NegativeNumberNotSupportedException");
        }

        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
