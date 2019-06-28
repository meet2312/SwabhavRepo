using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    delegate void DPrintMsg(string name);
    class Program
    {
        static void Main(string[] args)
        {
              Casestudy1();
              Casestudy2();

        }

        private static void Casestudy2()
        {
            DPrintMsg x, Y, z;
            x = (PrintHello);
            x("meet");
            z = (PrintGoodBye);
            x("meet");
            PrintAll(PrintHello);
            PrintAll(PrintGoodBye);
            Y = x + z;
            Y("qwerty");
           
        }

        private static void Casestudy1()
        {
            DPrintMsg x, z;
            x = (PrintHello);
            x("meet");
            z = (PrintGoodBye);
            x("meet");
            PrintAll(PrintHello);
            PrintAll(PrintGoodBye);
        }

        static void PrintHello(string name)
        {
            Console.WriteLine("Hello says {0}",name);
        }

        static void PrintGoodBye(string name)
        {
            Console.WriteLine("GoodBye says {0}", name);
        }

        static void Foo()
        {
          
        }

        static void PrintAll(DPrintMsg x)
        {
            Console.WriteLine("Inside Print ALl");
            x("champ");
        }
    }
}

