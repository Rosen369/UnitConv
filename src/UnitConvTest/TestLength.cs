using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConv;

namespace UnitConvTest
{
    [TestClass]
    public class TestLength
    {
        [TestMethod]
        public void TestKiloMeter()
        {
            var kilo = new Length(100, LengthType.Kilometer);
            Assert.AreEqual(kilo.ToMeter().Value, 100000);
        }
    }
}
