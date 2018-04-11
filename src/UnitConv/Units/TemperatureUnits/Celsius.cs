using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.TemperatureUnits
{
    public class Celsius : TemperatureUnit
    {
        private class Nested
        {
            internal static readonly Celsius Instance = new Celsius();
        }

        private Celsius()
        {

        }

        public static Celsius GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "摄氏度" },
                { Languages.English, "°C" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }

        protected override void InitSubtrahend()
        {
            _subtrahend = 273.15m;
        }
    }
}
