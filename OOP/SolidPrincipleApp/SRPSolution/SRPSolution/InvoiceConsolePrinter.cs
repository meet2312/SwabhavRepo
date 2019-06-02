using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolution
{
    class InvoiceConsolePrinter
    {
        public void PrintInvoice(Invoice inv)
        {
            Console.WriteLine("Invoice no:"+inv.Invoiceno);
            Console.WriteLine("Invoice name:" + inv.Invoicename);
            Console.WriteLine("Cost:" + inv.Cost);
            Console.WriteLine("Discount:" + inv.CalculateDiscount());
            Console.WriteLine("GST:" + inv.CalculateGST());
            Console.WriteLine("Total cost:" + inv.CalculateTotalCost());

        }
    }
}
