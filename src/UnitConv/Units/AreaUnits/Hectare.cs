using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class Hectare : AreaUnit
    {
        private class Nested
        {
            internal static readonly Hectare Instance = new Hectare();
        }

        private Hectare()
        {

        }

        public static Hectare GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "公顷" },
                { Languages.English, "ha" }
            };
        }

        protected override void InitRate()
        {
            _rate = 10000m;
        }
    }
}
