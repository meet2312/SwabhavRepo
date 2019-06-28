using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new Adaptar());
            var userResponses = client.GetResponsesRecieved();
        
            foreach (var response in userResponses)
            {
                Console.WriteLine(response);
            }
        }
    }
}
