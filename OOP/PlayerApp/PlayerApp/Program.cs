using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
              //     Casestudy1();
           
            Player p1 = new Player("abc",15,102);
         //   Console.WriteLine("count of players is :{0}",p1.);
            Player p2 = new Player("zxc", 10, 103);
        //    Console.WriteLine("count of players is :{0}",p2.Count);
            Player p3 = new Player("z", 17, 104);
        //    Console.WriteLine("count of players is :{0}", p1.Count);
          int c=  Player.GetCount();
            Console.WriteLine("Count:{0}", c);
        }

        private static void Casestudy1()
        {
            Player p1 = new Player("sachin", 10, 101);
            Player p2 = new Player("xyz", 11);
            PrintDetails(p1);
            PrintDetails(p2);
            Player elder = p1.WhoIsElder(p2);
            Console.WriteLine("Elder is {0}", elder.Name);
        }
        
        private  static void PrintDetails(Player player)
        {
            Console.WriteLine("Name:{0}", player.Name);
            Console.WriteLine("Age:{0}", player.Age);
            Console.WriteLine("Id:{0}", player.Id);

        }
    }
}
