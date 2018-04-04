using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class KilogramPerCubicMeter : DensityUnit
    {
        private class Nested
        {
            internal static readonly KilogramPerCubicMeter Instance = new KilogramPerCubicMeter();
        }

        private KilogramPerCubicMeter()
        {

        }

        public static KilogramPerCubicMeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克/立方米" },
                { Languages.English, "kg/m³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
