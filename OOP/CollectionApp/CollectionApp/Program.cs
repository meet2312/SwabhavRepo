using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            List<LineItem> cart = new List<LineItem>();
            cart.Add(new LineItem("camera", 3000, 10));
            cart.Add(new LineItem("laptop", 20000, 2));
            cart.Add(new LineItem("mobile", 5000, 5));
            //  cart.Add("meet");

            foreach (LineItem item in cart)
            {
                Console.WriteLine(item);
                double final = item.CalculateTotalCost();
                Console.WriteLine("final cost:{0}", final);

            }
        }

        private static void CaseStudy1()
        {
            ArrayList cart = new ArrayList();
            cart.Add(new LineItem("camera", 3000, 10));
            cart.Add(new LineItem("laptop", 20000, 2));
            cart.Add(new LineItem("mobile", 5000, 5));
            cart.Add("meet");
            cart.Add(100);

            foreach (Object item in cart)
            {
                Console.WriteLine((LineItem)item);

            }
        }
    }
}
