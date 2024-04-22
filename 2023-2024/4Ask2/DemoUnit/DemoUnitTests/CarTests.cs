using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnit.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {
            Car c = new Car("kamil", 5.6);
            Assert.IsNotNull(c);
            Assert.AreEqual(c.Najezd, 0);
            Assert.AreEqual(c.CelkovaSpotreba(), 0);
        }

        [TestMethod()]
        public void JizdaTest()
        {
            Car c = new Car("Milan", 7.2);
            c.Jizda(261);
            Assert.AreEqual(c.Najezd, 250);

        }

        [TestMethod()]
        public void CelkovaSpotrebaTest()
        {
            Car c = new Car("Milan", 7.2);
            c.Jizda(100);
            Assert.AreEqual(c.CelkovaSpotreba(), 7.2);
        }
    }
}