using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class GramForce : StrengthUnit
    {
        private class Nested
        {
            internal static readonly GramForce Instance = new GramForce();
        }

        private GramForce()
        {

        }

        public static GramForce GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克力" },
                { Languages.English, "gf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.806650m / 1000m;
        }
    }
}
