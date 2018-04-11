using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.TemperatureUnits
{
    public class Fahrenheit : TemperatureUnit
    {
        private class Nested
        {
            internal static readonly Fahrenheit Instance = new Fahrenheit();
        }

        private Fahrenheit()
        {

        }

        public static Fahrenheit GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "华氏度" },
                { Languages.English, "°F" }
            };
        }

        protected override void InitRate()
        {
            _rate = 5m / 9m;
        }

        protected override void InitSubtrahend()
        {
            _subtrahend = 273.15m - 32m * 5m / 9m;
        }
    }
}
