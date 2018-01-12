using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class BritishThermalUnitPerSecond : PowerUnit
    {
        private BritishThermalUnitPerSecond()
        {

        }

        private static readonly BritishThermalUnitPerSecond _instance = new BritishThermalUnitPerSecond();

        public static BritishThermalUnitPerSecond GetInstance()
        {
            return _instance;
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
