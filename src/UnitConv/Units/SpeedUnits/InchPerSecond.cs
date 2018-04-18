using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class InchPerSecond : SpeedUnit
    {
        private class Nested
        {
            internal static readonly InchPerSecond Instance = new InchPerSecond();
        }

        private InchPerSecond()
        {

        }

        public static InchPerSecond GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英寸/秒" },
                { Languages.English, "inch per second" },
                { Languages.Symbol, "in/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 25.400000m / 1000m;
        }
    }
}
