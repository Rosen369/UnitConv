using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class NauticalMile : LengthUnit
    {
        private class Nested
        {
            internal static readonly NauticalMile Instance = new NauticalMile();
        }

        private NauticalMile()
        {

        }

        public static NauticalMile GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "海里" },
                { Languages.English, "nautical mile" },
                { Languages.Symbol, "nmi" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1852m;
        }
    }
}
