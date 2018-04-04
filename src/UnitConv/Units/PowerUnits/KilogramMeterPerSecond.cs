using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class KilogramMeterPerSecond : PowerUnit
    {
        private class Nested
        {
            internal static readonly KilogramMeterPerSecond Instance = new KilogramMeterPerSecond();
        }

        private KilogramMeterPerSecond()
        {

        }

        public static KilogramMeterPerSecond GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克·米/秒" },
                { Languages.English, "kg·m/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.80665m;
        }
    }
}
