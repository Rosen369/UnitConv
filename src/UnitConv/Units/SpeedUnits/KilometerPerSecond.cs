using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class KilometerPerSecond : SpeedUnit
    {
        private KilometerPerSecond()
        {

        }

        private static readonly KilometerPerSecond _instance = new KilometerPerSecond();

        public static KilometerPerSecond GetInstance()
        {
            return _instance;
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
