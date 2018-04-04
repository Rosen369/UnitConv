using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class GramPerCubicMeter : DensityUnit
    {
        private class Nested
        {
            internal static readonly GramPerCubicMeter Instance = new GramPerCubicMeter();
        }

        private GramPerCubicMeter()
        {

        }

        public static GramPerCubicMeter GetInstance()
        {
            return Nested.Instance;
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
