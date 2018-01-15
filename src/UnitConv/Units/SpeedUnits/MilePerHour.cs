using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class MilePerHour : SpeedUnit
    {
        private MilePerHour()
        {

        }

        private static readonly MilePerHour _instance = new MilePerHour();

        public static MilePerHour GetInstance()
        {
            return _instance;
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
