using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicCentimeter : VolumeUnit
    {
        private CubicCentimeter()
        {

        }

        private static readonly CubicCentimeter _instance = new CubicCentimeter();

        public static CubicCentimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方厘米" },
                { Languages.English, "cm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
