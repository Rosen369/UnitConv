using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareInch : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareInch Instance = new SquareInch();
        }

        private SquareInch()
        {

        }

        public static SquareInch GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方英寸" },
                { Languages.English, "square inch" },
                { Languages.Symbol, "sq.in" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 0.3048m / 144m;
        }
    }
}
