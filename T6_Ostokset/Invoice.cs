using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Ostokset
{
    public class Invoice
    {
        public string Customer { get; }
        public List<InvoiceItem> Items { get; }

        public Invoice(string name)
        {
            this.Customer = name;
            this.Items = new List<InvoiceItem>();
        }



        public string Total()
        {
            double total = 0;
            foreach (InvoiceItem inv in Items)
            {
                total += inv.Total();
            }
            return string.Format("{0:C2}", total);
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Customer " + Customer + ":");
            foreach (InvoiceItem inv in Items)
            {
                Console.WriteLine(inv);
            }
            Console.WriteLine("Total: " + Total());
        }
    }
}
