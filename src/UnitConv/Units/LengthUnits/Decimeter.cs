using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Decimeter : LengthUnit
    {
        private class Nested
        {
            internal static readonly Decimeter Instance = new Decimeter();
        }

        private Decimeter()
        {

        }

        public static Decimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "分米" },
                { Languages.English, "dm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.1m;
        }
    }
}
