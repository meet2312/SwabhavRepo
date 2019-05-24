using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismExApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDbOperation(new CustomerDb());
            Console.WriteLine("");
            DoDbOperation(new SalesDb());
            Console.WriteLine("");
            DoDbOperation(new DepartmentDb());
        }

        public static void DoDbOperation(ICrudable crud)
        {
            Console.WriteLine("Doing db operations");
            crud.Create();
            crud.Read();
            crud.Update();
            crud.Delete();
        }
    }
}
