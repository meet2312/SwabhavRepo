using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public class CarStrategy:IStrategy
    {
        public string GetTravelTime(string source, string destination)
        {
            return "It takes 40 minutes to reach from " + source + " to " + destination + " using Car.";
        }
    }
}
