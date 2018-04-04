using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Kilometer : LengthUnit
    {
        private class Nested
        {
            internal static readonly Kilometer Instance = new Kilometer();
        }

        private Kilometer()
        {

        }

        public static Kilometer GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千米" },
                { Languages.English, "km" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
