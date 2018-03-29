using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitConv;

namespace UnitTest
{
    [TestClass]
    public class TestOperator
    {
        [TestMethod]
        public void TestEqualOperator()
        {
            var kilo = new Length(1.184m, LengthUnit.Kilometer);
            var meter = new Length(1184, LengthUnit.Meter);
            Assert.AreEqual(kilo == meter, true);
            Assert.AreEqual(kilo != meter, false);
            Assert.AreEqual(kilo >= meter, true);
            Assert.AreEqual(kilo <= meter, true);
        }

        [TestMethod]
        public void TestGreaterEqualOperator()
        {
            var kilo = new Length(1.184m, LengthUnit.Kilometer);
            var meter = new Length(1185, LengthUnit.Meter);
            Assert.AreEqual(kilo <= meter, true);
            Assert.AreEqual(kilo >= meter, false);
        }

        [TestMethod]
        public void TestGreaterOperator()
        {
            var kilo = new Length(1.184m, LengthUnit.Kilometer);
            var meter = new Length(1185, LengthUnit.Meter);
            Assert.AreEqual(kilo < meter, true);
            Assert.AreEqual(kilo > meter, false);
        }
    }
}
