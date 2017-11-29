using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConv;

namespace UnitConvTest
{
    [TestClass]
    public class TestArea
    {
        [TestMethod]
        public void TestSquareMileValue()
        {
            var sqKiloMeter = new Area(3m, AreaUnit.SquareKilometer);
            var sqMile = new Area(1.1583064756273375417886434181m, AreaUnit.SquareMile);
            Assert.AreEqual(sqMile.Equals(sqKiloMeter), true);
        }

        [TestMethod]
        public void TestSquareMileString()
        {
            var sqMile = new Area(100.1415m, AreaUnit.SquareMile);
            Assert.AreEqual(sqMile.ToString(), "100.142sq.mi");
            Assert.AreEqual(sqMile.ToString(Languages.ChineseSimplify), "100.142平方英里");
        }
    }
}
