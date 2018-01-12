using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class KilogramMeterPerSecond : PowerUnit
    {
        private KilogramMeterPerSecond()
        {

        }

        private static readonly KilogramMeterPerSecond _instance = new KilogramMeterPerSecond();

        public static KilogramMeterPerSecond GetInstance()
        {
            return _instance;
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
