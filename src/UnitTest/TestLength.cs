using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConv;
using UnitConv.Extension;

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
            Assert.AreEqual(kilo.ToString(Languages.Chinese), "100.142千米");
        }

        [TestMethod]
        public void TestMeterConstructor()
        {
            var meter1 = new Length(1184, LengthUnit.Meter);
            var meter2 = new Length("1184m");
            var meter3 = new Length("1184", "m");
            var meter4 = new Length(1184, "m");
            var meter5 = new Length("1184", LengthUnit.Meter);
            Assert.AreEqual(meter1.Equals(meter2), true);
            Assert.AreEqual(meter1.Equals(meter3), true);
            Assert.AreEqual(meter1.Equals(meter4), true);
            Assert.AreEqual(meter1.Equals(meter5), true);
        }
    }
}
