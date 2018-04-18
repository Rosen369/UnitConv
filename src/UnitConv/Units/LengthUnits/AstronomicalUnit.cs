using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class AstronomicalUnit : LengthUnit
    {
        private class Nested
        {
            internal static readonly AstronomicalUnit Instance = new AstronomicalUnit();
        }

        private AstronomicalUnit()
        {

        }

        public static AstronomicalUnit GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "天文单位" },
                { Languages.English, "astronomical unit" },
                { Languages.Symbol, "AU" }
            };
        }

        protected override void InitRate()
        {
            _rate = 149597870700m;
        }
    }
}
