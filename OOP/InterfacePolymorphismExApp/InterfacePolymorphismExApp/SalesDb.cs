using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismExApp
{
    class SalesDb:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Create sales db");
        }
        public void Read()
        {
            Console.WriteLine("Read sales db");
        }
        public void Update()
        {
            Console.WriteLine("Update sales db");
        }
        public void Delete()
        {
            Console.WriteLine("Delete sales db");
        }
    }
}
