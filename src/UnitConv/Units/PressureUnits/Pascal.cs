using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Pascal : PressureUnit
    {
        private class Nested
        {
            internal static readonly Pascal Instance = new Pascal();
        }

        private Pascal()
        {

        }

        public static Pascal GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "帕斯卡" },
                { Languages.English, "pascal" },
                { Languages.Symbol, "Pa" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
