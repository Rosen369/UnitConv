using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class FootPoundPerSecond : PowerUnit
    {
        private class Nested
        {
            internal static readonly FootPoundPerSecond Instance = new FootPoundPerSecond();
        }

        private FootPoundPerSecond()
        {

        }

        public static FootPoundPerSecond GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英尺·磅/秒" },
                { Languages.English, "foot pound per second" },
                { Languages.Symbol, "ft·lb/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 745.699872m / 550m;
        }
    }
}
