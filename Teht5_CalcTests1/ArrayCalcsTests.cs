using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teht5_Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5_Calc.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double[] testSet1 = { 0 };
            double[] testSet2 = { double.MaxValue, double.MinValue, 0 };
            double[] testSet3 = { 0.1, 0.1, 0, -12.009, -12.01, 58000.0002, -0.1, 58000 };
            double expected1 = 0;
            double expected2 = double.MaxValue + double.MinValue;
            double expected3 = 115976.0812;

            double result1 = ArrayCalcs.Sum(testSet1);
            double result2 = ArrayCalcs.Sum(testSet2);
            double result3 = ArrayCalcs.Sum(testSet3);
            
            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double[] testSet1 = { 0 };
            double[] testSet2 = { double.MaxValue, double.MinValue, 0 };
            double[] testSet3 = { 0.1, 0.1, 0, -12.009, -12.01, 58000.0002, -0.1, 58000 };
            double expected1 = 0;
            double expected2 = (double.MaxValue + double.MinValue) / 2;
            double expected3 = 14497.01015;

            double result1 = ArrayCalcs.Average(testSet1);
            double result2 = ArrayCalcs.Average(testSet2);
            double result3 = ArrayCalcs.Average(testSet3);

            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] testSet1 = { 0 };
            double[] testSet2 = { double.MaxValue, double.MinValue, 0 };
            double[] testSet3 = { 0.1, 0.1, 0, -12.009, -12.01, 58000.0002, -0.1, 58000 };
            double expected1 = 0;
            double expected2 = double.MinValue;
            double expected3 = -12.01;

            double result1 = ArrayCalcs.Min(testSet1);
            double result2 = ArrayCalcs.Min(testSet2);
            double result3 = ArrayCalcs.Min(testSet3);

            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] testSet1 = { 0 };
            double[] testSet2 = { double.MaxValue, double.MinValue, 0 };
            double[] testSet3 = { 0.1, 0.1, 0, -12.009, -12.01, 58000.0002, -0.1, 58000 };
            double expected1 = 0;
            double expected2 = double.MaxValue;
            double expected3 = 58000.0002;

            double result1 = ArrayCalcs.Max(testSet1);
            double result2 = ArrayCalcs.Max(testSet2);
            double result3 = ArrayCalcs.Max(testSet3);

            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
        }
    }
}