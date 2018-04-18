using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.TemperatureUnits
{
    public class Kelvin : TemperatureUnit
    {
        private class Nested
        {
            internal static readonly Kelvin Instance = new Kelvin();
        }

        private Kelvin()
        {

        }

        public static Kelvin GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "开氏度" },
                { Languages.English, "Kelvin" },
                { Languages.Symbol, "K" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }

        protected override void InitSubtrahend()
        {
            _subtrahend = 0m;
        }
    }
}
