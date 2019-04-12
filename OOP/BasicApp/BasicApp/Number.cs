using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApp
{
    class Number
    {
       // public static int GetMaxNumber(int[] no)
        //{
          //  Console.WriteLine(no.Length);
           
          //  for (int i = 0; i < no.Length; i++)
           // {
               
            //}
            //return max;
            //Console.WriteLine(max);
        

        public static int GetMaxNumber(int[] no)
        {
            int max = no[0];
            int a=0, secmax=0;
            for (int i = 0; i < no.Length; i++)
            {
                if (no[i] > max)
                {
                    max = no[i];
                }
                if (no[i] > a)
                {
                    secmax = a;
                    a = no[i];
                }
                else if (no[i]>secmax)
                {
                    secmax = no[i];
                }
            }
            return max;
            return secmax;
        }
    }
}
