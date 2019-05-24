using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismExApp
{
    class CustomerDb:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Create Customer db");
        }
        public void Read()
        {
            Console.WriteLine("Read Customer db");
        }
        public void Update()
        {
            Console.WriteLine("Update Customer db");
        }
        public void Delete()
        {
            Console.WriteLine("Delete Customer db");
        }
    }
}
