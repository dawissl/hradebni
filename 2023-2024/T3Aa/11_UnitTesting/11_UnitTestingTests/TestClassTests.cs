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
            // student prošel
            TestClass tc = new TestClass();

            Assert.IsTrue(tc.PassExam(28));
        }

        [TestMethod()]
        public void PassExamTest1()
        {
            // student neprošel
            TestClass tc = new TestClass();

            Assert.IsTrue(tc.PassExam(20));
        }
    }
}