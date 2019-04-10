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
            System.Console.WriteLine("parameter count = {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("url = [{1}]", i, args[i]);
                string url1 = args[i];
                Console.WriteLine(url1);
                //url1 = "http://www.aurionpro.com?developer=meet&location=rabale";
                string[] valueReplace = url1.Replace("//", "/").Split('/');
                string[] getDomain = valueReplace[1].Split('.');
                Console.WriteLine("Company name is " + getDomain[1]);
                string[] getLocation = url1.Split('&');
                Console.WriteLine(getLocation[1]);
                string[] getDeveloper = url1.Split('?');
                string[] getDev = getDeveloper[1].Split('&');
                Console.WriteLine(getDev[0]);
            }
            
           

        }
    }
}
