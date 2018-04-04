using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class BritishThermalUnitPerSecond : PowerUnit
    {
        private class Nested
        {
            internal static readonly BritishThermalUnitPerSecond Instance = new BritishThermalUnitPerSecond();
        }

        private BritishThermalUnitPerSecond()
        {

        }

        public static BritishThermalUnitPerSecond GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英热单位/秒" },
                { Languages.English, "Btu/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1055.05585m;
        }
    }
}
