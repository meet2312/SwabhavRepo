using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution
{
    class FixedDeposit
    {
        private string _name;
        private double _principal;
        private int _duration;
        private IFestivalRate _festival;

        public double Principal
        {
            get
            {
                return _principal;
            }
        }

        public FixedDeposit(string name,double principal,int duration, IFestivalRate festival)
        {
            this._name = name;
            this._principal = principal;
            this._duration = duration;
            this._festival = festival;

        }

        public double CalculateSimpleInterest()
        {
            double simpleinterest = _principal * _duration * _festival.GetRate();
            simpleinterest = Math.Round(simpleinterest, 2);
            return simpleinterest;
        }
    }

}
