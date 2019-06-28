using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib

{
    public class AudiFactory : IAutoMobileFactory
    {
        private static AudiFactory container;
        private  AudiFactory()
        {

        }
       
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
