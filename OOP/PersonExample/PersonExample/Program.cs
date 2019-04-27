using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "abc";
            p1.Height = 177;
            p1.Weight = 88;
            p1.Gender = 'M';

          //  p1.SetName("abc");
          //  p1.SetGender('M');
           // p1.SetHeight(175);
           // p1.SetWeight(75);

            Person p2 = new Person();
            //    p2.SetName("xyz");
            p2.Name = "xyz";
            p2.Height = 167;
            p2.Weight = 75;
            p2.Gender = 'F';
         //   p2.SetGender('F');
         //   p2.SetHeight(160);
         //   p2.SetWeight(80);

            Person p3 = new Person();
            p3.Name = "qwerty";
            p3.Height = 167;
            p3.Weight = 90;
            p3.Gender = 'M';
        //    p3.SetName("qwerty");
         //   p3.SetGender('M');
        //    p3.SetHeight(190);
         //   p3.SetWeight(70);

            Console.WriteLine("Name is:" + p1.Name);
            Console.WriteLine("Height is:" + p1.Height);
            Console.WriteLine("Weight is:" + p1.Weight);
            Console.WriteLine("Gender is:" + p1.Gender);

            Console.WriteLine("Name is:" + p2.Name);
            Console.WriteLine("Height is:" + p2.Height);
            Console.WriteLine("Weight is:" + p2.Weight);
            Console.WriteLine("Gender is:" + p2.Gender);

            Console.WriteLine("Name is:" + p3.Name);
            Console.WriteLine("Height is:" + p3.Height);
            Console.WriteLine("Weight is:" + p3.Weight);
            Console.WriteLine("Gender is:" + p3.Gender);

            p1.eat();
            p2.eat();
        
           // double w=p2.eat();
           // double w1 = p1.eat();


          //  Console.WriteLine("Weight after eat for "+p2.Name+" is:{0}", w);
          //  Console.WriteLine("Weight after eat for "+p1.Name+" is :{0}", w1);
          //   Console.WriteLine("Gender is:", p2.GetGender());

        }
    }
}
