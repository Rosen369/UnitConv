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
            var meter = UnitConverter.Length.Convert(kilo, LengthUnit.Meter);
            Assert.AreEqual(kilo.Equals(meter), true);
            Assert.AreEqual(kilo.ToMeter().Value, meter.Value);
            Assert.AreEqual(kilo.ToMile().Value, meter.ToMile().Value);
        }
    }
}
