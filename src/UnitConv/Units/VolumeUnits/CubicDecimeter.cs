using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicDecimeter : VolumeUnit
    {
        private class Nested
        {
            internal static readonly CubicDecimeter Instance = new CubicDecimeter();
        }

        private CubicDecimeter()
        {

        }

        public static CubicDecimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方分米" },
                { Languages.English, "dm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.001m;
        }
    }
}
