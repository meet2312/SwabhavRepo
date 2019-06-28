using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new Observer("Observer A");
            var observerB = new Observer("Observer B");
            var observerC = new Observer("Observer C");
            Console.WriteLine("Intially suppose Subject has already written total " + subject.Articles + " article");
            Console.WriteLine("\n*******************************************************************************\n");
            Console.WriteLine("Registering observers A and B for future articles...............");
            subject.registerObserver(observerA);
            subject.registerObserver(observerB);
            Console.WriteLine("New article published by Subject,so now observers A and B will be notified....\n");
            subject.Articles++;
            Console.WriteLine("---------------------------------------------------------------------------\n");
            Console.WriteLine("Registering observer C for future articles and unregistering observer B from the future articles...............");
            subject.registerObserver(observerC);
            subject.unregisterObserver(observerB);
            Console.WriteLine("New article published by Subject,so now observers A and C will be notified....\n");
            subject.Articles++;
            Console.WriteLine("\n*******************************************************************************\n");
            Console.WriteLine("Finally Subject has written total " + subject.Articles + " article\n");
        }
    }
}
