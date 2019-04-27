using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceEncapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Invoice invoice = new Invoice();
            invoice.Id = 2;
            invoice.Name = "Laptop";
            invoice.Description = "Repair";
            invoice.Cost = 200;
            invoice.Discount = 25;
            invoice.Tax = 10;
            p.DisplayDetails(invoice);
            Console.WriteLine("");
            Invoice invoice1 = new Invoice();
            invoice1.Id = 4;
            invoice1.Name = "Mobile";
            invoice1.Description = "Display screen";
            invoice1.Cost = 1000;
            invoice1.Discount = 40;
            invoice1.Tax = 5;
            p.DisplayDetails(invoice1);
        }

        private Invoice DisplayDetails(Invoice inv)
        {
            Console.WriteLine("id is :{0}", inv.Id);
            Console.WriteLine("name is :{0}", inv.Name);
            Console.WriteLine("description is :{0}", inv.Description);
            Console.WriteLine("cost is :{0}", inv.Cost);
            Console.WriteLine("discount is :{0}", inv.Discount);
            Console.WriteLine("tax is :{0}", inv.Tax);
            Console.WriteLine("Total cost is :{0}", inv.CalcTotalAmt());
            return inv;
       
        }
    }
}
