using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Nanometer : LengthUnit
    {
        private class Nested
        {
            internal static readonly Nanometer Instance = new Nanometer();
        }

        private Nanometer()
        {

        }

        public static Nanometer GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "纳米" },
                { Languages.English, "nm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000001m;
        }
    }
}
