using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitConv;

namespace UnitTest
{
    [TestClass]
    public class TestTemperature
    {
        [TestMethod]
        public void TestKelvin()
        {
            var kelvin = new Temperature(273.15m, TemperatureUnit.Kelvin);
            var celsius = kelvin.ConvertTo(TemperatureUnit.Celsius);
            Assert.AreEqual(celsius.Value.Equals(0), true);
        }

        [TestMethod]
        public void TestFahrenheit()
        {
            var celsius = new Temperature(0m, TemperatureUnit.Celsius);
            var fahrenheit = celsius.ConvertTo(TemperatureUnit.Fahrenheit);
            Assert.AreEqual(Convert.ToInt32(fahrenheit.Value).Equals(32), true);
        }
    }
}
