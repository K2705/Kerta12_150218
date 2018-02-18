using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Ostokset
{
    public class InvoiceItem
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; set; }

        public InvoiceItem(string name, double price)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = 0;
        }

        public InvoiceItem(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1:C2} ({2}) total {3}", Name, Price, Quantity, Total());
        }
    }
}
