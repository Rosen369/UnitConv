using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class GramPerCubicCentimeter : DensityUnit
    {
        private GramPerCubicCentimeter()
        {

        }

        private static readonly GramPerCubicCentimeter _instance = new GramPerCubicCentimeter();

        public static GramPerCubicCentimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克/立方厘米" },
                { Languages.English, "g/cm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1000m;
        }
    }
}
