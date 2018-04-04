using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class Newton : StrengthUnit
    {
        private class Nested
        {
            internal static readonly Newton Instance = new Newton();
        }

        private Newton()
        {

        }

        public static Newton GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "牛" },
                { Languages.English, "N" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
