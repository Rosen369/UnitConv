using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class Acre : AreaUnit
    {
        private class Nested
        {
            internal static readonly Acre Instance = new Acre();
        }

        private Acre()
        {

        }

        public static Acre GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英亩" },
                { Languages.English, "acre" },
                { Languages.Symbol, "acre" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 0.3048m * 16.5m * 16.5m * 160m;
        }
    }
}
