using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class EvenOdd
    {
        int num = 0;
        int series = 200;
        int[] even = new int[200];
        int[] odd = new int[200];

        public void PrintEvenSeries(int seriesno)
        {
            Console.WriteLine("Even numbers from 1 to "+seriesno+" are:");
            for (num = 1; num <= seriesno; num++)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + "\n");
                }

            }
            Console.WriteLine();
        }

        public void PrintEvenSeriesArray(int seriesno)
        {
            Console.WriteLine("Even numbers from 1 to " + seriesno + " are:");
            for (num = 1; num <= seriesno; num++)
            {
                if (num % 2 == 0)
                {
                    even[num]= num;
                    Console.Write(even[num] + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintOddSeries(int seriesno)
        {
            Console.WriteLine("Odd numbers from 1 to "+seriesno+" are:");
            for (num = 1; num <= seriesno; num++)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + "\n");
                }
            }
            Console.WriteLine();
        }

        public void PrintOddSeriesArray(int seriesno)
        {
            Console.WriteLine("Odd numbers from 1 to " + seriesno + " are:");
            for (num = 1; num <= seriesno; num++)
            {
                if (num % 2 != 0)
                {
                    odd[num] = num;
                    Console.Write(odd[num] + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
    
}
