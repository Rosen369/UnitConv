using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareMile : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareMile Instance = new SquareMile();
        }

        private SquareMile()
        {

        }

        public static SquareMile GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方英里" },
                { Languages.English, "square mile" },
                { Languages.Symbol, "sq.mi" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 3m * 1760m * 0.3048m * 3m * 1760m;
        }
    }
}
