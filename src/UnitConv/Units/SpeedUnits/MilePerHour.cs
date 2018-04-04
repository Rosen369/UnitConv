using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class MilePerHour : SpeedUnit
    {
        private class Nested
        {
            internal static readonly MilePerHour Instance = new MilePerHour();
        }

        private MilePerHour()
        {

        }

        public static MilePerHour GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英里/时" },
                { Languages.English, "mile/h" }
            };
        }

        protected override void InitRate()
        {
            _rate = 447.040000m / 1000m;
        }
    }
}
