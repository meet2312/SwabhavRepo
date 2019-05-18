using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            child1 ch1 = new child1();
            ch1.message();

            child2 ch2 = new child2();
            ch2.message();

        }
    }
}
class baseclass
{
    public virtual void message()
    {
        Console.WriteLine("I am base class Virtual Method");
    }
}
class child1 : baseclass
{
    public override void message()
    {
        Console.WriteLine("I am child 1 class");
    }
}
class child2 : baseclass
{
}
