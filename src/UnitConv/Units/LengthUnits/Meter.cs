using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Meter : LengthUnit
    {
        private class Nested
        {
            internal static readonly Meter Instance = new Meter();
        }

        private Meter()
        {

        }

        public static Meter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "米" },
                { Languages.English, "meter" },
                { Languages.Symbol, "m" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
