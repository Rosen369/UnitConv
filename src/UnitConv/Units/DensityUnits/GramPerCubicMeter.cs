using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class GramPerCubicMeter : DensityUnit
    {
        private GramPerCubicMeter()
        {

        }

        private static readonly GramPerCubicMeter _instance = new GramPerCubicMeter();

        public static GramPerCubicMeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克/立方米" },
                { Languages.English, "g/m³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1000m;
        }
    }
}
