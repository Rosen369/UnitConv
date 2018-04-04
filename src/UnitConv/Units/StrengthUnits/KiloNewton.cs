using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class KiloNewton : StrengthUnit
    {
        private class Nested
        {
            internal static readonly KiloNewton Instance = new KiloNewton();
        }

        private KiloNewton()
        {

        }

        public static KiloNewton GetInstance()
        {
            return Nested.Instance;
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
