using Microsoft.VisualStudio.TestTools.UnitTesting;
using T6_Ostokset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Ostokset.Tests
{
    [TestClass()]
    public class InvoiceTests
    {

        [TestMethod()]
        public void TotalTest()
        {
            Invoice test = new Invoice("test");
            test.Items.Add(new InvoiceItem("item1", 17.23, 2));
            test.Items.Add(new InvoiceItem("item2", 0, 25));
            test.Items.Add(new InvoiceItem("item3", 0.5, 10));
            string expected = "39.46 €";

            string result = test.Total();

            Assert.AreEqual(expected, result);
        }
    }
}