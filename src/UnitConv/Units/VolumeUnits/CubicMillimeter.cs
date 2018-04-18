using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicMillimeter : VolumeUnit
    {
        private class Nested
        {
            internal static readonly CubicMillimeter Instance = new CubicMillimeter();
        }

        private CubicMillimeter()
        {

        }

        public static CubicMillimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方毫米" },
                { Languages.English, "cubic millimeter" },
                { Languages.Symbol, "mm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000001m;
        }
    }
}
