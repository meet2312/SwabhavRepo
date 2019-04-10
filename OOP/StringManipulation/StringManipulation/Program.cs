using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        
        static void Main(string[] args)
        {
           // System.Console.WriteLine("parameter count = {0}", args.Length);
          //    System.Console.WriteLine("url = [{1}]", 1, args[1]);
           //     string url1 = args[1];
           //     Console.WriteLine(url1);
            
            
            string url = "http://www.aurionpro.com?developer=meet&location=rabale";
            string[] valueReplace = url.Replace("//", "/").Split('/');
            string[] getDomain = valueReplace[1].Split('.');
            Console.WriteLine("Company name is "+getDomain[1]);
            string[] getLocation = url.Split('&');
            Console.WriteLine(getLocation[1]);
            string[] getDeveloper = url.Split('?');
            string[] getDev = getDeveloper[1].Split('&');
            Console.WriteLine(getDev[0]);

        }
    }
}
