using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareYard : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareYard Instance = new SquareYard();
        }

        private SquareYard()
        {

        }

        public static SquareYard GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方码" },
                { Languages.English, "sq.yd" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 0.3048m * 9m;
        }
    }
}
