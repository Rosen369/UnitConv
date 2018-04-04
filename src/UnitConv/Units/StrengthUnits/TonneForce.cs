using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class TonneForce : StrengthUnit
    {
        private class Nested
        {
            internal static readonly TonneForce Instance = new TonneForce();
        }

        private TonneForce()
        {

        }

        public static TonneForce GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "公吨力" },
                { Languages.English, "tf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9806.650000m;
        }
    }
}
