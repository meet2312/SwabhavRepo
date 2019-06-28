using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adaptar : ITarget
    {
        public List<string> GetResponses()
        {
            return new ResponsesStore().GetResponsesRecieved();
        }
    }
}
