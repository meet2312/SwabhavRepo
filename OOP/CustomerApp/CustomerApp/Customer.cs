using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
   public class Customer
    {
        private string _name;
        private int _ordercount;
        private int _id;
        private static int id_generator;

        static Customer()
        {
            id_generator = 1000;
            Console.WriteLine("inside static constructor");
        }
        public Customer(string name,int ordercount)
        {
            this._name = name;
            this._ordercount = ordercount;
            id_generator++;
            _id = id_generator;
    
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int OrderCount
        {
            get
            {
                return _ordercount;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
    }
}
