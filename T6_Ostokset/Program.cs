using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Ostokset
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("Kirsi Kernel");
            {
                InvoiceItem milk = new InvoiceItem("Milk", 1.75);
                milk.Quantity = 2;
                InvoiceItem beer = new InvoiceItem("Beer", 5.25);
                beer.Quantity = 2;
                InvoiceItem butter = new InvoiceItem("Butter", 2.5);
                butter.Quantity = 1;
                invoice.Items.Add(milk);
                invoice.Items.Add(beer);
                invoice.Items.Add(butter);
            }
            invoice.PrintInvoice();
        }
    }
}
