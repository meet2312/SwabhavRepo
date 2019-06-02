using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryClient
{
    public class AudiFactory : IAutoMobileFactory
    {
        private static AudiFactory container;
        public IAutoMobile Make()
        {
            return new Audi();
        }
        public static AudiFactory GetInstance()
        {
            if (container == null)
            {
                container = new AudiFactory();
            }
            return container;
            //return new DataService();
        }


    }
}
