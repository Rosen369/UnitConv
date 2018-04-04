using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class KilometerPerSecond : SpeedUnit
    {
        private class Nested
        {
            internal static readonly KilometerPerSecond Instance = new KilometerPerSecond();
        }

        private KilometerPerSecond()
        {

        }

        public static KilometerPerSecond GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千米/秒" },
                { Languages.English, "km/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
