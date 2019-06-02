using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation
{
    class TaxCalculator
    {
        private LogType _logtype;
        public enum LogType
        {
            DB,FILE
        }

        public TaxCalculator(LogType logtype)
        {
            this._logtype = logtype;
        }

        public int Calculate(int amount , int rate)
        {
            try
            {
                int r = amount / rate;
                return r;
            }
            catch (Exception e)
            {
                //Console.WriteLine("{0}",e.Message);
                DBLogger db = new DBLogger();
                FileLogger file = new FileLogger();
                if (_logtype.Equals(LogType.DB))
                {
                     db.Log(e.Message);
            
                }
                else if(_logtype.Equals(LogType.FILE))
                {
                    file.Log(e.Message);
                }
            }
            return -1;
            
        }
    }
}
