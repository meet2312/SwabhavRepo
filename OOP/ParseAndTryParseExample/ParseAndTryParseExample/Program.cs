using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseAndTryParseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "24532";
            string str2 = null;
            string str3 = "5.87";
            string str4 = "98765432123456";
            int res;
           // try
          //  {
                // int.Parse() - TEST
                res = int.Parse(str1); // res = 24532
                res = int.Parse(str2); // System.ArgumentNullException
                res = int.Parse(str3); // System.FormatException
                res = int.Parse(str4); // System.OverflowException

                bool isParsed;
                isParsed = int.TryParse(str1, out res); // isParsed = true, res = 24532
                isParsed = int.TryParse(str2, out res); // isParsed = false, res = 0
                isParsed = int.TryParse(str3, out res); // isParsed = false, res = 0
                isParsed = int.TryParse(str4, out res); // isParsed = false, res = 0 
          //  }
            //catch (Exception e)
           // {
         //       Console.WriteLine("Check this.\n" + e.Message);
         //   }

        }
    }
}
