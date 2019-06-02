using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryClient
{
    public class BMWFactory : IAutoMobileFactory
    {
        private static BMWFactory container;
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
