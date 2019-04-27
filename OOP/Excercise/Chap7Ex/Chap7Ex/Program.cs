using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7Ex
{
     public class TestBoats
    {
        static void Main(string[] args)
        {
            Boat bl = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();
            b2.setLength(32);
            bl.move();
            b3.move();
            b2.move();
        }
    }

    public class Rowboat:Boat
    {
        public void rowTheBoat()
        {
            Console.WriteLine("stroke natasha");
        }
    }

    public class Sailboat : Boat
    {
        public void move()
        {
            Console.WriteLine("hoist sail");
        }
    }

    public class Boat
    {
        private int length;
        public void setLength(int len)
        {
            length = len;
        } 
        public int getLength()
        { return length; }
        public void move()
        {
            Console.WriteLine("drift");
        }
    }
}
