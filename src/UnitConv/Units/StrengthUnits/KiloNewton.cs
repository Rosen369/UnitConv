using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class KiloNewton : StrengthUnit
    {
        private KiloNewton()
        {

        }

        private static readonly KiloNewton _instance = new KiloNewton();

        public static KiloNewton GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千牛" },
                { Languages.English, "kN" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
