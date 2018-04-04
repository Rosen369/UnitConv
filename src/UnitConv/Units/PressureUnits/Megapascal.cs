using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Megapascal : PressureUnit
    {
        private class Nested
        {
            internal static readonly Megapascal Instance = new Megapascal();
        }

        private Megapascal()
        {

        }

        public static Megapascal GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "兆帕" },
                { Languages.English, "MPa" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
