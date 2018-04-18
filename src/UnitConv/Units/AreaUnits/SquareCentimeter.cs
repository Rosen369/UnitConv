using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareCentimeter : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareCentimeter Instance = new SquareCentimeter();
        }

        private SquareCentimeter()
        {

        }

        public static SquareCentimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方厘米" },
                { Languages.English, "square centimeter" },
                { Languages.Symbol, "cm²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0001m;
        }
    }
}
