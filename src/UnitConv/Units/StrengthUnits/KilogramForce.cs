using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class KilogramForce : StrengthUnit
    {
        private class Nested
        {
            internal static readonly KilogramForce Instance = new KilogramForce();
        }

        private KilogramForce()
        {

        }

        public static KilogramForce GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克力" },
                { Languages.English, "kilogram force" },
                { Languages.Symbol, "kgf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.806650m;
        }
    }
}
