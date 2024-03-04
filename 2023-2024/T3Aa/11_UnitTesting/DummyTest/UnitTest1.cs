using Microsoft.VisualStudio.TestTools.UnitTesting;
using _11_UnitTesting;

namespace _11_UnitTesting.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void PassExamTest()
        {
            Assert.Fail();
        }
    }
}

namespace DummyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}