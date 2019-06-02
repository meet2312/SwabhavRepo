using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClient
{
    public class BMWFactory : IAutoMobileFactory
    {
        public IAutoMobile Make()
        {
            throw new NotImplementedException();
        }
    }
}
