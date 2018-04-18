using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class KilometerPerHour : SpeedUnit
    {
        private class Nested
        {
            internal static readonly KilometerPerHour Instance = new KilometerPerHour();
        }

        private KilometerPerHour()
        {

        }

        public static KilometerPerHour GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千米/时" },
                { Languages.English, "kilometer per hour" },
                { Languages.Symbol, "km/h" }
            };
        }

        protected override void InitRate()
        {
            _rate = 277.777778m / 1000m;
        }
    }
}
