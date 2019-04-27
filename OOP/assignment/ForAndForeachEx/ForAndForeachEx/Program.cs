using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForeachEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            Console.WriteLine("using for loop");
            for (int i=1;i<=5;i++)
            {
                j = j + i;
               
                Console.WriteLine(j);
            }
            
            int[] myArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("using foreach");
            foreach (int i in myArr)
            {
                j = j + i;
                
                Console.WriteLine(j);

            }
        }
    }
}
