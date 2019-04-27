using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Invoice invoice = new Invoice();
            invoice.id = 1;
            invoice.name = "laptop invoice";
            invoice.description = "Repairing cost";
            invoice.cost = -100;
            invoice.tax = -5;
            invoice.discount = 20f;
            double final = invoice.CalcTotalCost();
            p.PrintDetails(invoice);
         /*   Console.WriteLine("id is :{0}", invoice.id);
            Console.WriteLine("name is :{0}", invoice.name);
            Console.WriteLine("description is :{0}", invoice.description);
            Console.WriteLine("cost is :{0}", invoice.cost);
            Console.WriteLine("discount is :{0}%", invoice.discount);
            Console.WriteLine("tax is :{0}%", invoice.tax);
            Console.WriteLine("Total cost is :{0}", final); */
            Console.WriteLine("");
            Invoice invoice1 = new Invoice();
            invoice1.id = 2;
            invoice1.name = "Mobile Invoice";
            invoice1.description = "Display Screen";
            invoice1.cost = 500;
            invoice1.discount = 50;
            invoice1.tax = 10;
            double total = invoice1.CalcTotalCost();
            p.PrintDetails(invoice1);
        /*    Console.WriteLine("id is :{0}", invoice1.id);
            Console.WriteLine("name is :{0}", invoice1.name);
            Console.WriteLine("description is :{0}", invoice1.description);
            Console.WriteLine("cost is :{0}", invoice1.cost);
            Console.WriteLine("discount is :{0}%", invoice1.discount);
            Console.WriteLine("tax is :{0}%", invoice1.tax);
            Console.WriteLine("Total cost is :{0}", total);
            */

        }

        public Invoice PrintDetails(Invoice inv)
        {
            Console.WriteLine("id is :{0}", inv.id);
            Console.WriteLine("name is :{0}", inv.name);
            Console.WriteLine("description is :{0}", inv.description);
            Console.WriteLine("cost is :{0}", inv.cost);
            Console.WriteLine("discount is :{0}", inv.discount);
            Console.WriteLine("tax is :{0}", inv.tax);
            Console.WriteLine("Total cost is :{0}", inv.CalcTotalCost());
            return inv;
        }
    }
}
