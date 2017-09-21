using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsComponentNameSpace;

namespace MathCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Subtract(10, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSubtract2()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }
    }
}
