using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class GramPerCubicCentimeter : DensityUnit
    {
        private class Nested
        {
            internal static readonly GramPerCubicCentimeter Instance = new GramPerCubicCentimeter();
        }

        private GramPerCubicCentimeter()
        {

        }

        public static GramPerCubicCentimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克/立方厘米" },
                { Languages.English, "gram per cubic centimeter" },
                { Languages.Symbol, "g/cm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1000m;
        }
    }
}
