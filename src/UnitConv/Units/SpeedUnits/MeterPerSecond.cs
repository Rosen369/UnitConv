using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class MeterPerSecond : SpeedUnit
    {
        private MeterPerSecond()
        {

        }

        private static readonly MeterPerSecond _instance = new MeterPerSecond();

        public static MeterPerSecond GetInstance()
        {
            return _instance;
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
