using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class KilogramPerCubicCentimeter : DensityUnit
    {
        private class Nested
        {
            internal static readonly KilogramPerCubicCentimeter Instance = new KilogramPerCubicCentimeter();
        }

        private KilogramPerCubicCentimeter()
        {

        }

        public static KilogramPerCubicCentimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克/立方厘米" },
                { Languages.English, "kg/cm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000000m;
        }
    }
}
