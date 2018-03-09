using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class BritishThermalUnit : WorkUnit
    {
        private BritishThermalUnit()
        {

        }

        private static readonly BritishThermalUnit _instance = new BritishThermalUnit();

        public static BritishThermalUnit GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英热单位" },
                { Languages.English, "btu" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1055.05585262m;
        }
    }
}
