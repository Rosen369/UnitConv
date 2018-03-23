using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConv;
using UnitConv.Utils;

namespace UnitConvTest
{
    [TestClass]
    public class TestUtil
    {
        [TestMethod]
        public void TestConvertValue()
        {
            var valueStr = "2342.5342";
            var result = Util.ConvertValue(valueStr);
            Assert.AreEqual(result.Equals(2342.5342m), true);
        }

        [TestMethod]
        public void TestConvertUnit()
        {
            var unitStr = "km";
            var result = Util.ConvertUnit<LengthUnit>(unitStr);
            Assert.AreEqual(result.Equals(LengthUnit.Kilometer), true);
        }
    }
}
