using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
           // CaseStudy2();
           // CaseStudy3();
           // CaseStudy4();

        }
        public static void CaseStudy1()
        {
            Man man;
            man = new Man();
            man.Play();
            man.Eat();

        }

        public static void CaseStudy2()
        {
            Boy boy;
            boy = new Boy();
            boy.Play();
            boy.Walk();
            boy.Eat();
            boy.Run();
        }
        public static void CaseStudy3()
        {
            Man x;
            x = new Boy();
            x.Play();
            x.Eat();
        }
        public static void CaseStudy4()
        {
            ThePark(new Man());
            ThePark(new Boy());
            ThePark(new Kid());
            ThePark(new Infant());
        }

        private static void ThePark(Man man)
        {
            Console.WriteLine("At the Park");
            man.Play();
        }
    }
}
