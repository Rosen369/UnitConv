using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class KilopoundForce : StrengthUnit
    {
        private class Nested
        {
            internal static readonly KilopoundForce Instance = new KilopoundForce();
        }

        private KilopoundForce()
        {

        }

        public static KilopoundForce GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千磅力" },
                { Languages.English, "kip" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4448.221615m;
        }
    }
}
