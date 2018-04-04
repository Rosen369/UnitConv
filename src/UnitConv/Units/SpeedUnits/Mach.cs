using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class Mach : SpeedUnit
    {
        private class Nested
        {
            internal static readonly Mach Instance = new Mach();
        }

        private Mach()
        {

        }

        public static Mach GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "马赫" },
                { Languages.English, "mach" }
            };
        }

        protected override void InitRate()
        {
            _rate = 340.300000m;
        }
    }
}
