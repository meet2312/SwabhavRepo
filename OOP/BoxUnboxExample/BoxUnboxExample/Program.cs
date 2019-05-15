using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxUnboxExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 34;
            object ob = i;
            int j = (int)ob;

            float f = 222f;
            object o = f;
            float m = (float)o;

         

            double e = 2.718281828459045;
            object obj = e; // box
            int ee = (int)(double)obj;      //unboxing

            Int32 x = 10;
            object a = x;     // implicit
            int q = (int)a;

            Int32 y = 10;
            object ad = (object)y;      //explicit 
            Console.WriteLine(ad);             

            Console.WriteLine("val is:{0}", j);
            Console.WriteLine("val is:{0}", m);
        
            Console.WriteLine("val is:{0}", ee);
            Console.WriteLine("val :{0}",q);

            bool b = false;
            object p = b;
            bool b2 = (bool)p;
            Console.WriteLine(b2);


            int i1 = 12;
            object box = i1;
            if (box is int)
            {
                Console.Write("Box contains an int");
            }

        }
    }
}
