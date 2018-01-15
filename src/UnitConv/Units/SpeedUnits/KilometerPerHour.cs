using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class KilometerPerHour : SpeedUnit
    {
        private KilometerPerHour()
        {

        }

        private static readonly KilometerPerHour _instance = new KilometerPerHour();

        public static KilometerPerHour GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千米/时" },
                { Languages.English, "km/h" }
            };
        }

        protected override void InitRate()
        {
            _rate = 277.777778m / 1000m;
        }
    }
}
