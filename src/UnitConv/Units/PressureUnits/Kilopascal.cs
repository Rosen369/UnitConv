using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Kilopascal : PressureUnit
    {
        private class Nested
        {
            internal static readonly Kilopascal Instance = new Kilopascal();
        }

        private Kilopascal()
        {

        }

        public static Kilopascal GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千帕" },
                { Languages.English, "kPa" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
