using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Yard : LengthUnit
    {
        private class Nested
        {
            internal static readonly Yard Instance = new Yard();
        }

        private Yard()
        {

        }

        public static Yard GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "码" },
                { Languages.English, "yard" },
                { Languages.Symbol, "yd" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.304794m * 3m;
        }
    }
}
