using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Hectopascal : PressureUnit
    {
        private class Nested
        {
            internal static readonly Hectopascal Instance = new Hectopascal();
        }

        private Hectopascal()
        {

        }

        public static Hectopascal GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "百帕" },
                { Languages.English, "hectopascal" },
                { Languages.Symbol, "hPa" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100m;
        }
    }
}
