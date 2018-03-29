using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitConv;
using UnitConv.Extension;

namespace UnitTest
{
    [TestClass]
    public class TestConverter
    {
        [TestMethod]
        public void TestConverterKiloMeter()
        {
            var kilo = new Length(1.184m, LengthUnit.Kilometer);
            var meter1 = UnitConverter.Length.Convert(kilo, LengthUnit.Meter);
            var meter2 = UnitConverter.Length.Convert(kilo, "m");
            var meter3 = UnitConverter.Length.Convert("1.184km", LengthUnit.Meter);
            var meter4 = UnitConverter.Length.Convert("1.184km", "m");
            var meter5 = UnitConverter.Length.Convert(1.184m, "km", "m");
            var meter6 = UnitConverter.Length.Convert(1.184m, LengthUnit.Kilometer, LengthUnit.Meter);
            Assert.AreEqual(kilo.Equals(meter1), true);
            Assert.AreEqual(kilo.ToMeter().Value, meter1.Value);
            Assert.AreEqual(kilo.ToMile().Value, meter1.ToMile().Value);
            Assert.AreEqual(kilo.Equals(meter2), true);
            Assert.AreEqual(kilo.Equals(meter3), true);
            Assert.AreEqual(kilo.Equals(meter4), true);
            Assert.AreEqual(kilo.Equals(meter5), true);
            Assert.AreEqual(kilo.Equals(meter6), true);
        }
    }
}
