using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicCentimeter : VolumeUnit
    {
        private class Nested
        {
            internal static readonly CubicCentimeter Instance = new CubicCentimeter();
        }

        private CubicCentimeter()
        {

        }

        public static CubicCentimeter GetInstance()
        {
            return Nested.Instance;
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
