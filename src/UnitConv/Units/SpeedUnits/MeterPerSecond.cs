using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class MeterPerSecond : SpeedUnit
    {
        private class Nested
        {
            internal static readonly MeterPerSecond Instance = new MeterPerSecond();
        }

        private MeterPerSecond()
        {

        }

        public static MeterPerSecond GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "米/秒" },
                { Languages.English, "m/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
