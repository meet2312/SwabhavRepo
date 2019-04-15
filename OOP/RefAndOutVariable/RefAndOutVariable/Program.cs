using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutVariable
{
    class Program
    {

        static void Main(string[] args)
        {
            //using ref 
            int i = 1;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test = GetNextName(ref i);
            Console.WriteLine("Current value of integer i:" + i.ToString());
            //using out
            int i1 = 0;
            Console.WriteLine("Previous value of integer i:" + i1.ToString());
            string test1 = GetNextNameByOut(out i1);
            Console.WriteLine("Current value of integer i:" + i1.ToString());
        }

        public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;

        }
       
        public static string GetNextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
    }
}
