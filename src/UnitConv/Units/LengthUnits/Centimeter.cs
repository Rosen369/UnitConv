using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Centimeter : LengthUnit
    {
        private class Nested
        {
            internal static readonly Centimeter Instance = new Centimeter();
        }

        private Centimeter()
        {

        }

        public static Centimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "厘米" },
                { Languages.English, "centimeter" },
                { Languages.Symbol, "cm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.01m;
        }
    }
}
