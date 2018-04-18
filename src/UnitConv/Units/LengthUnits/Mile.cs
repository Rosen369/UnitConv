using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Mile : LengthUnit
    {
        private class Nested
        {
            internal static readonly Mile Instance = new Mile();
        }

        private Mile()
        {

        }

        public static Mile GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英里" },
                { Languages.English, "mile" },
                { Languages.Symbol, "mi" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.304794m * 3m * 1760m;
        }
    }
}
