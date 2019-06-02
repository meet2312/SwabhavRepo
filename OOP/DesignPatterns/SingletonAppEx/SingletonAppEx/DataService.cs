using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAppEx
{
    class DataService
    {
        private static DataService container;
        private DataService()
        {
            Console.WriteLine("Service created");
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something by "+this.GetHashCode());
        }

        public static DataService GetInstance()
        {
            if(container == null)
            {
                container = new DataService();
            }
            return container;
            //return new DataService();
        }
    }
}
