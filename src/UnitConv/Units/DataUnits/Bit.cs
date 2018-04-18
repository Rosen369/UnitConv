using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Bit : DataUnit
    {
        private class Nested
        {
            internal static readonly Bit Instance = new Bit();
        }

        private Bit()
        {

        }

        public static Bit GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "比特" },
                { Languages.English, "bit" },
                { Languages.Symbol, "b" }
            };
        }

        protected override void InitRate()
        {
            _rate = 8m;
        }
    }
}
