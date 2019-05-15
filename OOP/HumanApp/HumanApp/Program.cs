using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human meet = new Human("meet", 24, 175.5f, 63f, GenderOptions.MALE);
            Human priyank = new Human("priyank", 23, 172.4f, 59f, GenderOptions.MALE);
            PrintInfo(meet);
            PrintInfo(priyank);
            priyank.Eat();
            PrintInfo(priyank);
        }

        private  static void PrintInfo(Human human)
        {
            Console.WriteLine("Name:{0}", human.Name);
            Console.WriteLine("Age:{0}", human.Age);
            Console.WriteLine("Height:{0}", human.Height);
            Console.WriteLine("Weight:{0}", human.Weight);
            Console.WriteLine("Gender:{0}", human.Gender);
            Console.WriteLine("");
        }

       
    }
}
