using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP500.Tests
{
    [TestClass()]
    public class DluhopisTests
    {
        [TestMethod()]
        public void DluhopisTestTime1()
        {
            Dluhopis d1 = new Dluhopis("Abc", 1, 5000, 11);
            Assert.IsFalse(d1.DelkaZadrzeni >= 12);
        }

        [TestMethod()]
        public void DluhopisTestTime2()
        {
            Dluhopis d2 = new Dluhopis("Abc", 1, 5000, 50);
            Assert.IsTrue(d2.DelkaZadrzeni >= 12);
            Assert.IsTrue(d2.DelkaZadrzeni <= 60);
        }

        [TestMethod()]
        public void DluhopisTestTime3()
        {
            Dluhopis d3 = new Dluhopis("Abc", 1, 5000, 500);
            Assert.IsFalse(d3.DelkaZadrzeni <= 60);
        }

        [TestMethod()]
        public void UroceniTest()
        {
            Dluhopis d1 = new Dluhopis("Abc", 6.3, 5000, 50);
            d1.Uroceni();
            Assert.Equals(d1.DelkaZadrzeni, 49);
            Assert.Equals(d1.Vynos, 5026.25);
        }

        [TestMethod()]
        public void CistyVynosTest()
        {
            Dluhopis d1 = new Dluhopis("Abc", 6.3, 5000, 50);
            d1.Uroceni();
            Assert.Equals(d1.Vynos, 26.25);
        }
    }
}