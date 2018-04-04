using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicMeter : VolumeUnit
    {
        private class Nested
        {
            internal static readonly CubicMeter Instance = new CubicMeter();
        }

        private CubicMeter()
        {

        }

        public static CubicMeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方米" },
                { Languages.English, "m³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
