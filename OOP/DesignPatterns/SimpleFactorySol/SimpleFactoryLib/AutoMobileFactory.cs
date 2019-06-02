using SimpleFactoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibClient
{
   public class AutoMobileFactory
    {
        private static AutoMobileFactory container;
        private AutoMobileFactory()
        {

        }

        public static AutoMobileFactory GetInstance()
        {
            if(container == null)
            {
                container = new AutoMobileFactory();
            }
            return container;
           // return new AutoMobileFactory();
        }
        public IAutoMobile Make(AutoType type)
        {
            if(type == AutoType.AUDI)
            {
                return new Audi();
            }
            else if(type == AutoType.BMW)
            {
                return new BMW();

            }
            else if(type == AutoType.TESLA)
            {
                return new Tesla();
            }
            return null;
        }
        
    }

    public enum AutoType
    {
        BMW,TESLA,AUDI
    }
}
