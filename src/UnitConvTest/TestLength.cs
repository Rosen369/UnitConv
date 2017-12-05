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
            var kilo = new Length(1.184m, LengthUnit.Kilometer);
            var meter = new Length(1184, LengthUnit.Meter);
            Assert.AreEqual(kilo.Equals(meter), true);
            Assert.AreEqual(kilo.ToMeter().Value, meter.Value);
            Assert.AreEqual(kilo.ToMeter().Value, 1184);
            Assert.AreEqual(kilo.ToMile().Value, meter.ToMile().Value);
        }

        [TestMethod]
        public void TestKiloMeterString()
        {
            var kilo = new Length(100.1415m, LengthUnit.Kilometer);
            Assert.AreEqual(kilo.ToString(), "100.142km");
            Assert.AreEqual(kilo.ToString(Languages.ChineseSimplify), "100.142千米");
        }
    }
}
