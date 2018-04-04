using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class NewtonMeterPerSecond : PowerUnit
    {
        private class Nested
        {
            internal static readonly NewtonMeterPerSecond Instance = new NewtonMeterPerSecond();
        }

        private NewtonMeterPerSecond()
        {

        }

        public static NewtonMeterPerSecond GetInstance()
        {
            return Nested.Instance;
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
