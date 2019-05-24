using AccountApp.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
  //  [Serializable]
    class InsufficientFundsException : Exception
    {
        private Account _acc;
        public InsufficientFundsException(Account _a)
        {
           
            this._acc = _a;
        }

        public Account ac
        {
            get
            {
                return _acc;
            }
        }

        public override string ToString()
        {
            return "Balance:" + _acc.Balance + "";
        }
    }
}
        