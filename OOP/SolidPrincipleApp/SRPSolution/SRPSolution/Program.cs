using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Laptop invoice", 5000, 0.5f, 0.18f);
            InvoiceConsolePrinter invoiceprint = new InvoiceConsolePrinter();
            invoiceprint.PrintInvoice(invoice);

        }
    }
}
