using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismExApp
{
    class DepartmentDb:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Create dept db");
        }
        public void Read()
        {
            Console.WriteLine("Read dept db");
        }
        public void Update()
        {
            Console.WriteLine("Update dept db");
        }
        public void Delete()
        {
            Console.WriteLine("Delete dept db");
        }
    }
}
