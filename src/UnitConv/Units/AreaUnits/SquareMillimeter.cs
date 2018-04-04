using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareMillimeter : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareMillimeter Instance = new SquareMillimeter();
        }

        private SquareMillimeter()
        {

        }

        public static SquareMillimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方毫米" },
                { Languages.English, "mm²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
