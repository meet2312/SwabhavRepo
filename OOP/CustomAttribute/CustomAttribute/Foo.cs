using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    
    public class Foo
    {
        [AddChangesLater]
         void M1()
        {
            
        }
        void M2()
        {
           
        }
        [AddChangesLater]
        void M3()
        {

        }
    }
}
