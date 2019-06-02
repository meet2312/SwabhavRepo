using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
    class TaxCalculator
    {
        private ILogger _logtype;
        public TaxCalculator(ILogger logtype)
        {
            this._logtype = logtype;
        }

        internal ILogger Logtype
        {
            get
            {
                return _logtype;
            }
        }

        public int Calculate(int amount , int rate)
        {
            try
            {
                int r = amount / rate;
                return r;
            }
            catch(Exception e)
            {
                _logtype.Log(e.Message);
               
            }
            return -1;

        }
    }
}
