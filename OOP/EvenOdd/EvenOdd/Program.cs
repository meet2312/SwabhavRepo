using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
       

        static void Main(string[] args)
        {
            // Program p = new Program();
            int[] no = { 17, 22, 90, 57, 43, 38, 2, 71, 9, 20, 74, 66 };

           // System.Console.WriteLine("parameter count = {0}", args.Length);
          //  for (int i = 0; i < args.Length; i++)
          //  {
                //System.Console.WriteLine("url = [{1}]", i, args[i]);
               // int numbers = int.Parse(args[i]);
                
             //   Console.WriteLine(numbers);
               
        //    }
            //Console.Write(no[0] + " ");
            //Console.WriteLine("Till which no do u want series ?");
            //int seriesno = Convert.ToInt16(Console.ReadLine());
            //EvenOdd n = new EvenOdd();
            //n.PrintEvenSeries(seriesno);
            //n.PrintEvenSeriesArray(seriesno);

            PrintEvenSeriesArray(no);
           PrintOddSeriesArray(no);
            //n.PrintOddSeries(seriesno);
            //n.PrintOddSeriesArray(seriesno);

        }

        private static void PrintEvenSeriesArray(int[] no)
        {
            Console.WriteLine("List of even numbers : ");
            for (int num = 0; num < no.Length; num++)
            {
                //condition for EVEN number
                if (no[num] % 2 == 0)
                    Console.Write(no[num] + " ");
            }
            Console.WriteLine();

        }

        private static void PrintOddSeriesArray(int[] no)
        {
            Console.WriteLine("List of odd numbers : ");
            for (int num = 0; num < no.Length; num++)
            {
                //condition for ODD number
                if (no[num] % 2 != 0)
                    Console.Write(no[num] + " ");
            }
            Console.WriteLine();

        }

        public static int[] GetEvenNoArray(int[] no)
        {
            int[] evenarr =new int[no.Length];
            for (int num = 0; num < no.Length; num++)
            {
                //condition for EVEN number
                if (no[num] % 2 == 0)
                {
                    for (int i = 0; i < no.Length; i++)
                    {
                        evenarr[i] = no[num];
                    }
                   
                }

                //   Console.Write(no[num] + " ");
            }
            return evenarr;

        }

        public static int[] GetOddNoArray(int[] no)
        {
            int[] oddarr = new int[no.Length];
            for (int num = 0; num < no.Length; num++)
            {
                //condition for EVEN number
                if (no[num] % 2 != 0)
                {
                    for (int i = 0; i < no.Length; i++)
                    {
                        oddarr[i] = no[num];
                    }

                }

                //   Console.Write(no[num] + " ");
            }
            return oddarr;

        }
    }
}
