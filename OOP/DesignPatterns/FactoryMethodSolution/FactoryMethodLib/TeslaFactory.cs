﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib
{
    public class TeslaFactory : IAutoMobileFactory
    {
        private static TeslaFactory container;
        private TeslaFactory()
        {

        }
        public IAutoMobile Make()
        {
            return new Tesla();
        }

        public static TeslaFactory GetInstance()
        {
            if (container == null)
            {
                container = new TeslaFactory();
            }
            return container;
            //return new DataService();
        }
    }
}
