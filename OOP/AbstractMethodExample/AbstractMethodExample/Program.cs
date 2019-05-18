using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Number ch = new Number();
            ch.Sum();
            ch.Product();
           
        }
    }
}
abstract class Base
{
    public int num = 5;
    public abstract void Sum();
    public abstract void Product();
}
class Number : Base
{
    public override void Sum()
    {
        Console.WriteLine("Total Sum : " + num + num);
    }
    public override void Product()
    {
        Console.WriteLine("Total Product : " + num * num);
    }
}
