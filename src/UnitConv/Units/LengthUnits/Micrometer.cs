using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Micrometer : LengthUnit
    {
        private class Nested
        {
            internal static readonly Micrometer Instance = new Micrometer();
        }

        private Micrometer()
        {

        }

        public static Micrometer GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "微米" },
                { Languages.English, "micrometer" },
                { Languages.Symbol, "um" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
