using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation
{
    class FixedDeposit
    {
        private string _name;
        private double _principal;
        private int _duration;
        private FestivalType _festival;

        public double Principal
        {
            get
            {
                return _principal;
            }
        }

        public FixedDeposit(string name,double principal,int duration, FestivalType festival)
        {
            this._name = name;
            this._principal = principal;
            this._duration = duration;
            this._festival = festival;

        }

        public double CalculateSimpleInterest()
        {
            double simpleinterest = 0;
            if (_festival == FestivalType.NORMAL)
            {
                simpleinterest = _principal * _duration * 0.07;
            }
             else if (_festival == FestivalType.HOLI)
            {
                simpleinterest = _principal * _duration * 0.08;
            }
            else if(_festival == FestivalType.DIWALI)
            {
                simpleinterest = _principal * _duration * 0.09;
            }
            return simpleinterest;
        }
    }

    public enum FestivalType
    {
        NORMAL,HOLI,DIWALI
    }
}
