using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Millibar : PressureUnit
    {
        private class Nested
        {
            internal static readonly Millibar Instance = new Millibar();
        }

        private Millibar()
        {

        }

        public static Millibar GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫巴" },
                { Languages.English, "millibar" },
                { Languages.Symbol, "mbar" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100m;
        }
    }
}
