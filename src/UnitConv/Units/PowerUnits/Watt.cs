using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class Watt : PowerUnit
    {
        private class Nested
        {
            internal static readonly Watt Instance = new Watt();
        }

        private Watt()
        {

        }

        public static Watt GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "瓦" },
                { Languages.English, "watt" },
                { Languages.Symbol, "W" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
