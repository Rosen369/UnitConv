using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class NewtonMeterPerSecond : PowerUnit
    {
        private NewtonMeterPerSecond()
        {

        }

        private static readonly NewtonMeterPerSecond _instance = new NewtonMeterPerSecond();

        public static NewtonMeterPerSecond GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "牛顿·米/秒" },
                { Languages.English, "N·m/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
