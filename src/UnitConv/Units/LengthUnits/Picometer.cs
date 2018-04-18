using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Picometer : LengthUnit
    {
        private class Nested
        {
            internal static readonly Picometer Instance = new Picometer();
        }

        private Picometer()
        {

        }

        public static Picometer GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "皮米" },
                { Languages.English, "picometer" },
                { Languages.Symbol, "pm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000000001m;
        }
    }
}
