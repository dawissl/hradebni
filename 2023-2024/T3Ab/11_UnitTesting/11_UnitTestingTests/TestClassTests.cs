using Microsoft.VisualStudio.TestTools.UnitTesting;
using _11_UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_UnitTesting.Tests
{
    [TestClass()]
    public class TestClassTests
    {
        [TestMethod()]
        public void PassExamTest()
        {
            TestClass t = new TestClass();
            Assert.IsTrue(t.PassExam(30));
        }

        [TestMethod()]
        public void PassExamTest1()
        {
            TestClass t = new TestClass();
            Assert.IsTrue(t.PassExam(10));
        }

        [TestMethod()]
        public void DecreaseAmountTest()
        {
            TestClass t = new TestClass();
            Assert.AreEqual(t.DecreaseAmount(20), "Z účtu byla vybrána částka 20");
            Assert.AreEqual(t.Amount, 80);

        }
    }
}