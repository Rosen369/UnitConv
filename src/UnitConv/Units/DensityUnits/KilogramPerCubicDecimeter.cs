using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class KilogramPerCubicDecimeter : DensityUnit
    {
        private class Nested
        {
            internal static readonly KilogramPerCubicDecimeter Instance = new KilogramPerCubicDecimeter();
        }

        private KilogramPerCubicDecimeter()
        {

        }

        public static KilogramPerCubicDecimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克/立方分米" },
                { Languages.English, "kg/dm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
