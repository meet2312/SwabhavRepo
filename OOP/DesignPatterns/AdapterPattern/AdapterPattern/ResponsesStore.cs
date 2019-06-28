using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ResponsesStore
    {
        public List<string> GetResponsesRecieved()
        {
            var responses = new List<string>()
        {
            "This is a test response by user 1",
            "This is a test response by user 2",
            "This is a test response by user 3",
            "This is a test response by user 4"
        };
            return responses;
        }
    }
}