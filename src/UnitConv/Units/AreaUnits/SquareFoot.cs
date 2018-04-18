using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareFoot : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareFoot Instance = new SquareFoot();
        }

        private SquareFoot()
        {

        }

        public static SquareFoot GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方英尺" },
                { Languages.English, "square foot" },
                { Languages.Symbol, "sq.ft" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 0.3048m;
        }
    }
}
