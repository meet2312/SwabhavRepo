using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6Example
{
    public class ArrayListMagnet
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(0);
            a.Add("zero");
            a.Add(1);
            a.Add("one");
            a.Add(2);
            a.Add("two");
            a.Add(3);
            a.Add("three");
            printAL(a);
            if (a.Contains("three"))
            {
                a.Add("four");
            }
            a.Remove(2);
            printAL(a);
            if (a.IndexOf("four") != 4)
            {
                a.Add(4);
                a.Add("4.2");
            }
            printAL(a);
            if (a.Contains("two"))
            {
                a.Add("2.2");
            }
            printAL(a);
        }


        public static void printAL(ArrayList al)
        {
            foreach(object obj in al)
            {
                Console.Write("{0}\t",obj);
            }
            Console.WriteLine(" ");
        }
    }
}
