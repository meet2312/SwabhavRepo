using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
    class FileLogger : ILogger
    {
        
        public void Log(string msg)
        {
            Console.WriteLine("In file logger");
        }
    }
}
