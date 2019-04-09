using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("Hello {1}", i, args[i]);

            }

        }


    }
}
