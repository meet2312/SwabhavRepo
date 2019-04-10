using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {

        private static void PrintThis(string text)
        {
            Console.WriteLine(text);
        }
        private static void PrintThis(int n)
        {
            Console.WriteLine(n);
        }
        private static void PrintThis(bool value)
        {
    
            Console.WriteLine(value);
        }
        private static void PrintThis(char val)
        {
            Console.WriteLine(val);
        }
        private static void PrintThis(double d)
        {
            Console.WriteLine(d);
        }
        private static void PrintThis(object value)
        {
            Console.WriteLine(value);
        }


        static void Main(string[] args)
        {

            bool ans = false;
            //writeline(string)
            Console.WriteLine("This is the first line.");

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

            //writeline(bool)
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

            //writeline(uint)
            uint value1 = 100;
            Console.WriteLine(value1);

            Console.WriteLine(typeof(uint));

            Console.WriteLine(args);
            
            if (isAdult != true)
                Console.Write(isAdult);


            //using printthis() method
            PrintThis(10);
            PrintThis("Hello");
            PrintThis(true);
            PrintThis('#');
            PrintThis(10.5);
            PrintThis(args);
       
         
        }

     
            
            
           
       
        

    }


}

