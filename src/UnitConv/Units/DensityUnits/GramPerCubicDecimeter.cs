using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class GramPerCubicDecimeter : DensityUnit
    {
        private class Nested
        {
            internal static readonly GramPerCubicDecimeter Instance = new GramPerCubicDecimeter();
        }

        private GramPerCubicDecimeter()
        {

        }

        public static GramPerCubicDecimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克/立方分米" },
                { Languages.English, "g/dm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
