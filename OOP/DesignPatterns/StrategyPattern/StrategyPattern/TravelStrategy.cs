using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
  public class TravelStrategy
    {
        private IStrategy _strategy;
        public TravelStrategy(IStrategy selectedstrategy)
        {
            _strategy = selectedstrategy;
        }
        public void GetTravelTime(string source, string destination)
        {
            var result = _strategy.GetTravelTime(source, destination);
            Console.WriteLine(result);
        }
    }
}
