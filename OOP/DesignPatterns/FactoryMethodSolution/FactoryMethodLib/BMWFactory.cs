using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib
{
    public class BMWFactory : IAutoMobileFactory
    {
        private static BMWFactory container;
        private BMWFactory()
        {

        }
        
        public IAutoMobile Make()
        {
            return new BMW();
        }

        public static BMWFactory GetInstance()
        {
            if (container == null)
            {
                container = new BMWFactory();
            }
            return container;
            //return new DataService();
        }
    }
}
