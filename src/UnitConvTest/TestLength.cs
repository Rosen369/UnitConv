using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConv;

namespace UnitConvTest
{
    [TestClass]
    public class TestLength
    {
        [TestMethod]
        public void TestKiloMeterValue()
        {
            var kilo = new Length(100, LengthType.Kilometer);
            Assert.AreEqual(kilo.ToMeter().Value, 100000);
        }

        [TestMethod]
        public void TestKiloMeterString()
        {
            var kilo = new Length(100.1415f, LengthType.Kilometer);
            Assert.AreEqual(kilo.ToString(), "100.142km");
        }
    }
}
