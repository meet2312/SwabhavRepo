using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorStaticEx
{
    class Test1
    {
        private static int id;
        static Test1()
        {
            if (Test1.id < 10)
            {
                id = 20;
            }
            else
            {
                id = 100;
            }
            Console.WriteLine("Static<Class> Constructor for Class Test1 Called..");
        }
        public static void print()
        {
            Console.WriteLine("Test1.id = " + id);
        }
        static void Main(string[] args)
        {
            Test1.print();
        }
    }
}
