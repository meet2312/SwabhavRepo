using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDotComTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDotCom dot = new SimpleDotCom();
            int[] locations = { 2 , 3 , 4 };
            dot.SetLocationCells(locations);
            string userguess = "2";
            string result = dot.CheckYourself(userguess);
            string testresult = "failed";
            if(result.Equals("hit"))
            {
                testresult = "passed";
            }
            Console.WriteLine(testresult);
        }
    }
}
