using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Nose[] i = new Nose[3];
            i[0] = new Acts();
            i[1] = new Clowns();
           // i[2] = new Picasso();



            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine(i[x].iMethod() + " " + i[x].getClass());
            }
        }

        class Acts : Picasso
        {
            public int iMethod()
            {
                return 5;
            }
        }

        class Clowns : Picasso
        {
            
        }
       
       abstract class Picasso : Nose
        {
         h   public string getClass()
            {
                throw new NotImplementedException();
            }

            public int iMethod()
            {
                return 7;
            }
        }

        interface Nose
        {
            string getClass();
            int iMethod();
        }
    }
}

