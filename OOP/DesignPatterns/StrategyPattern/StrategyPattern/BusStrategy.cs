using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class BusStrategy:IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "It takes 60 minutes to reach from " + source + " to " + destination + " using Bus.";
        }
    }
}
