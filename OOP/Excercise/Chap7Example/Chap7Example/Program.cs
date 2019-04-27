using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Monster[] mon = new Monster[3];
            mon[0]= new Vampire();
            mon[1] = new Dragon();
            mon[2] = new Monster();

            for(int x=0;x<3;x++)
            {

                mon[x].frighten(x);
            }
        }
    }

    class Monster
    {
        public bool frighten(int d)
        {
            Console.WriteLine("arrgh");

            return true;
        }
    }


    class Vampire : Monster
    {
        public bool frighten(int x)
        {
            Console.WriteLine("a bite?");

            return false;
        }
    }

    class Dragon : Monster
    {
        public bool frighten(int degree)
        {
            Console.WriteLine("breath fire");

            return true;
        }
    }
}
