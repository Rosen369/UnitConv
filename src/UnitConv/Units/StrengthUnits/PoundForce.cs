using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class PoundForce : StrengthUnit
    {
        private class Nested
        {
            internal static readonly PoundForce Instance = new PoundForce();
        }

        private PoundForce()
        {

        }

        public static PoundForce GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "磅力" },
                { Languages.English, "pound force" },
                { Languages.Symbol, "lbf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4.448222m;
        }
    }
}
