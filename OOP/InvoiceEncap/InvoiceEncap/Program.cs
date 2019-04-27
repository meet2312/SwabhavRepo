using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceEncap
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Invoice[] invoice = new Invoice[3];
            invoice[0] = new Invoice();
            invoice[1] = new Invoice();
            invoice[2] = new Invoice();
      //      Invoice invoice = new Invoice();
            invoice[0].SetId(10);
            invoice[0].SetName("Laptop");
            invoice[0].SetDescription("Increased RAM");
            invoice[0].SetDiscount(30);
            invoice[0].SetCost(5000);
            invoice[0].SetTax(10);
            PrintDetails(invoice[0]);
            Console.WriteLine("");
     //       Invoice invoice1 = new Invoice();
            invoice[1].SetId(10);
            invoice[1].SetName("Mobile");
            invoice[1].SetDescription(" RAM");
            invoice[1].SetDiscount(30);
            invoice[1].SetCost(900);
            invoice[1].SetTax(10);
            PrintDetails(invoice[1]);
            Console.WriteLine("");
            invoice[2].SetId(10);
            invoice[2].SetName("Laptop");
            invoice[2].SetDescription("Increased RAM");
            invoice[2].SetDiscount(30);
            invoice[2].SetCost(400);
            invoice[2].SetTax(10);
            PrintDetails(invoice[2]);
            Console.WriteLine("");
            double total = invoice[0].GetCost() + invoice[1].GetCost() + invoice[2].GetCost();
            Console.WriteLine("total is :{0}", total);
            Console.WriteLine("");
            Invoice temp = invoice[0];
          //  Console.WriteLine(temp.GetCost());
        //    temp = null;
      //      Console.WriteLine(invoice[0].GetCost());
            //Console.WriteLine(temp.GetCost());
            Console.WriteLine("Anonymous obj:" + new Invoice().GetCost());

           PrintDetails(new Invoice());
        //    Invoice temp = invoice;
       //     Console.WriteLine(temp.GetCost());
        //    Console.WriteLine(invoice.GetCost());
       //     temp.SetCost(7000);
       //     Console.WriteLine(temp.GetCost());
       //     Console.WriteLine(invoice.GetCost());

        }

        
       static Invoice PrintDetails(Invoice inv)
        {
            Console.WriteLine("id is :{0}", inv.GetId());
            Console.WriteLine("name is :{0}", inv.GetName());
            Console.WriteLine("description is :{0}", inv.GetDescription());
            Console.WriteLine("cost is :{0}", inv.GetCost());
            Console.WriteLine("discount is :{0}", inv.GetDiscount());
            Console.WriteLine("tax is :{0}", inv.GetTax());
            Console.WriteLine("Total cost after discount is :{0}", inv.CalcTotalCost());
            return inv;
        }
    }
}
