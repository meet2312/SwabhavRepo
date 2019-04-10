using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //writeline(string)
            string[] lines = { "This is the first line." };
             Console.WriteLine(lines);

            //writeline(object)
            Console.WriteLine(DateTime.Now);

            //writeline(double)
            double number1 = 11.22;
            Console.WriteLine(number1);

            //writeline(float)
            float f = 11.90f;
            Console.WriteLine(f);

            //writeline(decimal)
            Console.WriteLine(Math.Round(Convert.ToDecimal(32432432423 / 1450.0), 2));


            //writeline(uint)
            UInt16 a = 12345;
            UInt16 b = 65000;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            //writeline(long)
            long longValue1 = 4294967296;
            Console.WriteLine(longValue1);


            Console.WriteLine();

            bool isAdult = true;
            if (isAdult == true)
                Console.WriteLine(isAdult);

            //writeline( ulongValue)
            ulong ulongValue1 = 7934076125;
            Console.WriteLine(ulongValue1);

            //writeline(int)
            int no = 22;
            Console.WriteLine(no);


            Random rnd = new Random();
                Boolean bln = Convert.ToBoolean(rnd.Next(0, 2));
                Console.WriteLine("True or False: {0}", bln);



            uint value1 = 100;
            Console.WriteLine(value1);

            Console.WriteLine(typeof(uint));



            
            if (isAdult != true)
                Console.Write(isAdult);


        }
        }
}
