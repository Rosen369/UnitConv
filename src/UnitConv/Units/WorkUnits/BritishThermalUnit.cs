using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class BritishThermalUnit : WorkUnit
    {
        private class Nested
        {
            internal static readonly BritishThermalUnit Instance = new BritishThermalUnit();
        }

        private BritishThermalUnit()
        {

        }

        public static BritishThermalUnit GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英热单位" },
                { Languages.English, "British thermal unit" },
                { Languages.Symbol, "btu" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1055.05585262m;
        }
    }
}
