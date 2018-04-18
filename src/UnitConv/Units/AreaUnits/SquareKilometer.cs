using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareKilometer : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareKilometer Instance = new SquareKilometer();
        }

        private SquareKilometer()
        {

        }

        public static SquareKilometer GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方千米" },
                { Languages.English, "square kilometer" },
                { Languages.Symbol, "km²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000000m;
        }
    }
}
