using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Millimeter : LengthUnit
    {
        private class Nested
        {
            internal static readonly Millimeter Instance = new Millimeter();
        }

        private Millimeter()
        {

        }

        public static Millimeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫米" },
                { Languages.English, "mm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.001m;
        }
    }
}
