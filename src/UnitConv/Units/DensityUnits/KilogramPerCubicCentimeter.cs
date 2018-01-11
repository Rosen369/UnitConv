using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class KilogramPerCubicCentimeter : DensityUnit
    {
        private KilogramPerCubicCentimeter()
        {

        }

        private static readonly KilogramPerCubicCentimeter _instance = new KilogramPerCubicCentimeter();

        public static KilogramPerCubicCentimeter GetInstance()
        {
            return _instance;
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
