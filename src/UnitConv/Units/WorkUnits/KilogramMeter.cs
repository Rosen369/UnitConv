using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class KilogramMeter : WorkUnit
    {
        private KilogramMeter()
        {

        }

        private static readonly KilogramMeter _instance = new KilogramMeter();

        public static KilogramMeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克·米" },
                { Languages.English, "kg·m" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.80392157m;
        }
    }
}
