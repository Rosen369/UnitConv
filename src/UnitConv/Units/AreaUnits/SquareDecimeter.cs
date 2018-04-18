using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareDecimeter : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareDecimeter Instance = new SquareDecimeter();
        }

        private SquareDecimeter()
        {

        }

        public static SquareDecimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方分米" },
                { Languages.English, "square decimeter"},
                { Languages.Symbol, "dm²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.01m;
        }
    }
}
