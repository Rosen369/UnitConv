using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareMeter : AreaUnit
    {
        private class Nested
        {
            internal static readonly SquareMeter Instance = new SquareMeter();
        }

        private SquareMeter()
        {

        }

        public static SquareMeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方米" },
                { Languages.English, "m²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
